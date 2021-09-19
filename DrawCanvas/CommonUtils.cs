using System;

namespace DrawCanvas
{
    public class CommonUtils
    {
        public const char EmptyChar = '\0';
        public const char HorizonatalSeprator = '-';
        public const char VerticalSeprator = '|';
        public const char DrawingChar = 'x';

        public const char Reactangle = 'R';
        public const char Line = 'L';
        public const char Canvas = 'C';
        public const char BackColor = 'B';
        public const char Quit = 'Q';

        public static ConsoleColor ConsoleForegroundColor = Console.ForegroundColor;
        public static ConsoleColor ConsoleBackgroundColor = Console.BackgroundColor;
    }
}