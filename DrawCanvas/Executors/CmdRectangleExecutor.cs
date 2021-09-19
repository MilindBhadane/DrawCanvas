using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System;

namespace DrawCanvas.Executors
{
    public class CmdRectangleExecutor : BaseExecutor, ICmdProcessor
    {
        public override void ProcessCommand(IBaseCommand command, ref Canvas canvas)
        {
            CmdReactangle cmdRectangle = command as CmdReactangle;

            if (!IsPixelOnCanvas(cmdRectangle.TopLeft, canvas) || !IsPixelOnCanvas(cmdRectangle.RightBottom, canvas))
            {
                Console.WriteLine("Invalid coordinates provided for Rectangle. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }

            int x1 = cmdRectangle.TopLeft.X;
            int y1 = cmdRectangle.TopLeft.Y;
            int x2 = cmdRectangle.RightBottom.X;
            int y2 = cmdRectangle.RightBottom.Y;

            DrawHorizontalLine(x1, y1, x2, y1, canvas); // Draw "TOP" Horizontal Line
            DrawHorizontalLine(x1, y2, x2, y2, canvas); // Draw "BOTTOM" Horizontal Line
            DrawVerticleLine(x1, y1, x1, y2, canvas); // Draw "LEFT" Vertical Line
            DrawVerticleLine(x2, y1, x2, y2, canvas); // Draw "RIGHT" Vertical Line
        }
    }
}