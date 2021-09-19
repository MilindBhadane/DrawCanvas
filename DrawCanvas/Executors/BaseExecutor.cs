using DrawCanvas.Interfaces;
using System;
using System.Drawing;

namespace DrawCanvas.Executors
{
    public class BaseExecutor : ICmdProcessor
    {
        public virtual void ProcessCommand(IBaseCommand command, ref Canvas canvas)
        {
            throw new Exception("Can't execute Base Executor Process Command.");
        }

        public void DrawVerticleLine(int x1, int y1, int x2, int y2, Canvas canvas)
        {
            for (int index = y1 - 1; index < y2; index++)
            {
                canvas.AssignValueToCanvasPoint(x1 - 1, index, CommonUtils.DrawingChar);
            }
        }

        public void DrawVerticleLine(Point startPoint, Point endPoint, Canvas canvas)
        {
            for (int index = startPoint.Y - 1; index < endPoint.Y; index++)
            {
                canvas.AssignValueToCanvasPoint(startPoint.X - 1, index, CommonUtils.DrawingChar);
            }
        }

        public void DrawHorizontalLine(int x1, int y1, int x2, int y2, Canvas canvas)
        {
            for (int index = x1 - 1; index < x2; index++)
            {
                canvas.AssignValueToCanvasPoint(index, y1 - 1, CommonUtils.DrawingChar);
            }
        }

        public void DrawHorizontalLine(Point startPoint, Point endPoint, Canvas canvas)
        {
            for (int index = startPoint.X - 1; index < endPoint.X; index++)
            {
                canvas.AssignValueToCanvasPoint(index, startPoint.Y - 1, CommonUtils.DrawingChar);
            }
        }

        public bool IsPixelOnCanvas(Point p, Canvas canvas)
        {
            return p.X >= 0 && p.Y >= 0 && p.X < canvas.GetWidth() && p.Y <= canvas.GetHeight();
        }

        public bool IsPixelOnLineOrRectangle(Point p, Canvas canvas)
        {
            char isCharAlreadyExists = canvas.GetPointChar(p.X, p.Y);
            return isCharAlreadyExists == CommonUtils.EmptyChar ? true : false;

            //return p.X >= 0 && p.Y >= 0 && p.X < canvas.GetWidth() && p.Y <= canvas.GetHeight();
        }
    }
}