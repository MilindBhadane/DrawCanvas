using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawCanvas.Executors
{
    public class CmdBackColorExecutor : BaseExecutor, ICmdProcessor
    {
        private Canvas _canvas;

        public override void ProcessCommand(IBaseCommand command, ref Canvas canvas)
        {
            _canvas = canvas;
            CmdBackColor cmdBackColor = command as CmdBackColor;
            var startPoint = new Point { X = cmdBackColor.Point.X - 1, Y = cmdBackColor.Point.Y - 1 };
            if (!IsPixelOnCanvas(startPoint, _canvas) || !IsPixelOnLineOrRectangle(startPoint, _canvas))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid startpoint for background color. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }
            ColorAdjacentPoints(startPoint, cmdBackColor.CharToPrint);
        }

        private void ColorAdjacentPoints(Point point, char color)
        {
            if (_canvas.GetPointChar(point.X, point.Y) != CommonUtils.EmptyChar)
            {
                return;
            }
            else
            {
                _canvas.AssignValueToCanvasPoint(point.X, point.Y, color);

                List<Point> adjacentPoints = GetAdjacentPoints(point, _canvas);

                foreach (Point p in adjacentPoints)
                {
                    ColorAdjacentPoints(p, color);
                }
            }
        }

        private bool IsValidAdjacentPoint(Point pnt, Canvas canvas)
        {
            return pnt.Y < canvas.GetHeight() ? true : false;
        }

        private List<Point> GetAdjacentPoints(Point point, Canvas canvas)
        {
            int[] range = new int[] { -1, 0, 1 };
            int x = 0;
            int y = 0;

            List<Point> adjacentPoints = new List<Point>();

            foreach (var itemX in range)
            {
                foreach (var itemY in range)
                {
                    x = point.X + itemX;
                    y = point.Y + itemY;

                    if (y < canvas.GetHeight() && y > -1 && x > -1 && x < canvas.GetWidth())
                    {
                        adjacentPoints.Add(new Point(x, y));
                    }
                }
            }

            return adjacentPoints;
        }

        /*
         -1 -1   0 -1   +1 -1
         -1  0   0  0   +1  0
         -1 +1   0 +1   +1 +1

         */
    }
}