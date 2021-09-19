using DrawCanvas.Executors;
using DrawCanvas.Interfaces;
using DrawCanvas.Parsers;
using System;
using System.Collections.Generic;

namespace DrawCanvas
{
    public class ReadDrawingCommands
    {
        public static Canvas DrawingCanvas;

        public static void InitializeDrawingCommands()
        {
            try
            {
                ReadCommands();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while Reading command. Error Details: " + ex.ToString());
            }
        }

        private static void ReadCommands()
        {
            string input = string.Empty;

            while (!input.StartsWith("Q") || !input.StartsWith("q"))
            {
                DrawCanvas();
                input = Program.ReadCommand();
                ParseAndProcessCommand(input);
            };
        }

        private static void DrawCanvas()
        {
            if (DrawingCanvas != null)
            {
                CanvasWriter canvasWriter = new CanvasWriter(DrawingCanvas);
                canvasWriter.WriteOnConsole();
            }
        }

        public static void ParseAndProcessCommand(string commandText)
        {
            try
            {
                IParser commandParser = ParserFactory.GetCommandParser(commandText);
                if (commandParser != null)
                {
                    IBaseCommand command = commandParser.ParseCommand();
                    List<string> errors = Validator.ValidateCommand(command);
                    if (errors != null && errors.Count > 0)
                    {
                        Console.WriteLine("Validation errors are found in processing command. \nHence processing for this command will be skipped.");
                        Console.WriteLine(string.Join("\n", errors));
                        Console.ReadLine();
                    }
                    else
                    {
                        ICmdProcessor processor = CmdExecutorFactory.GetCommandProcessor(command);
                        processor.ProcessCommand(command, ref DrawingCanvas);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error occured while parsing and processsing command.\n You can continue with next command. Please enter to continue..");
                Console.WriteLine("Error details: {0}", exp.Message);
                Console.ReadLine();
            }
        }
    }
}