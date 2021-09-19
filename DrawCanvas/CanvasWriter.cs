using System;

namespace DrawCanvas
{
    public class CanvasWriter
    {
        private Canvas _canvas;

        public CanvasWriter(Canvas canvas)
        {
            _canvas = canvas;
        }

        public void WriteOnConsole()
        {
            Console.WriteLine("Canvas:");

            PrintHorizonatalBorder(true);
            for (int yIndex = 0; yIndex < _canvas.GetHeight(); yIndex++)
            {
                PrintCanvasSideChar();
                for (int xIndex = 0; xIndex < _canvas.GetWidth(); xIndex++)
                {
                    if (CommonUtils.DrawingChar == _canvas.GetPointChar(xIndex, yIndex))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(CommonUtils.DrawingChar);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(_canvas.GetPointChar(xIndex, yIndex));
                    }
                }

                PrintCanvasSideChar();
                Console.Write(yIndex + 1);
                Console.Write(Environment.NewLine);
            }

            PrintHorizonatalBorder(false);
        }

        private void PrintHorizonatalBorder(bool isIndexPrinted)
        {
            if (isIndexPrinted)
            {
                int width = _canvas.GetWidth();
                int rem = 0;
                int line1 = 0;

                string str1 = " ";
                string str2 = " ";

                for (int xIndex = 1; xIndex <= width; xIndex++)
                {
                    rem = xIndex % 10;
                    line1 = xIndex / 10;

                    str1 += line1.ToString();
                    str2 += rem.ToString();
                }

                Console.WriteLine(str1);
                Console.WriteLine(str2);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int xIndex = 0; xIndex < _canvas.GetWidth() + 2; xIndex++)
            {
                Console.Write(CommonUtils.HorizonatalSeprator);
            }
            Console.Write(Environment.NewLine);
            Console.ForegroundColor = CommonUtils.ConsoleForegroundColor;
        }

        private void PrintCanvasSideChar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(CommonUtils.VerticalSeprator);
            Console.ForegroundColor = CommonUtils.ConsoleForegroundColor;
        }
    }
}