using System;

namespace DrawCanvas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DisplayRules();
            ReadDrawingCommands.InitializeDrawingCommands();
        }

        public static string ReadCommand()
        {
            Console.WriteLine("............................................................................");
            Console.WriteLine("\nPlease enter the Command to draw on Canvas:");

            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            if (input.Contains("help"))
            {
                Console.Clear();

                DisplayRules();
                ReadCommand();
            }

            Console.ForegroundColor = CommonUtils.ConsoleForegroundColor;
            return input;
        }

        public static void DisplayRules()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(" Console App to Draw Canvas");
            Console.WriteLine("----------------------------------------------------------------------------\n");
            Console.WriteLine(" User can follow below steps while using the application.");
            Console.WriteLine(" 1. Use command \"C\" - For Creating Canvas");
            Console.WriteLine("                      e.g. Canvas Creation Command: [C 10 10]");
            Console.WriteLine(" 2. Use command \"R\" - For reactangle ");
            Console.WriteLine("                      e.g. Rectangle command: [R 3 3 5 5]");
            Console.WriteLine("                \"L\" - For Vertical / Horizontal Line");
            Console.WriteLine("                      e.g. Horizontal line command: [L 1 2 6 2]");
            Console.WriteLine("                      e.g. Vertical line command: [L 6 3 6 4]");
            Console.WriteLine("                \"B\" - For Bucket fill effect");
            Console.WriteLine("                      e.g. Bucket Fill line command: [B 7 3 o]");
            Console.WriteLine(" 3. Use Command \"Q\" or \"q\" to quit the application.");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}