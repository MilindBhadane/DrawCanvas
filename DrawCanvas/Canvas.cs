using System;

namespace DrawCanvas
{
    public class Canvas
    {
        private int width = -1;
        private int height = -1;
        private char[,] canvasCordinates;

        public Canvas(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                width = x;
                height = y;
                canvasCordinates = new char[width, height];
            }
            else
            {
                throw new Exception("Canvas cordinates are invalid.");
            }
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public char[,] GetCanvasPoints()
        {
            return canvasCordinates;
        }

        public char GetPointChar(int x, int y)
        {
            try
            {
                return canvasCordinates[x, y];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching value from Position: [{x}], [{y}]");
                throw ex;
            }
        }

        public void AssignValueToCanvasPoint(int x, int y, char ch)
        {
            canvasCordinates[x, y] = ch;
        }

        public void InitialiseCanvasToChar(char defaultChar)
        {
            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++)
                {
                    canvasCordinates[widthIndex, heightIndex] = CommonUtils.EmptyChar;
                }
            }
        }
    }
}