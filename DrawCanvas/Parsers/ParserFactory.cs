using DrawCanvas.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DrawCanvas.Parsers
{
    public class ParserFactory
    {
        public static IParser GetCommandParser(string commandText)
        {
            IParser commandParser = null;
            List<string> commandParams = commandText.Split(' ').ToList();
            char commandName = commandParams.First().First();

            switch (commandName)
            {
                case CommonUtils.Canvas:
                    commandParser = new CanvasParser(commandText);
                    break;

                case CommonUtils.Line:
                    commandParser = new LineParser(commandText);
                    break;

                case CommonUtils.Reactangle:
                    commandParser = new ReactangleParser(commandText);
                    break;

                case CommonUtils.BackColor:
                    commandParser = new BackColorParser(commandText);
                    break;

                default: break;
            }

            return commandParser;
        }
    }
}