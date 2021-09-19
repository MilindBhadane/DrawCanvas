using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System;
using System.Drawing;

namespace DrawCanvas.Executors
{
    public class CmdLineExecutor : BaseExecutor, ICmdProcessor
    {
        public override void ProcessCommand(IBaseCommand command, ref Canvas canvas)
        {
            CmdLine lineCommand = command as CmdLine;

            if (!IsPixelOnCanvas(lineCommand.StartPoint, canvas) || !IsPixelOnCanvas(lineCommand.EndPoint, canvas))
            {
                Console.WriteLine("Invalid coordinates provided for line. Processor will skip to execute this command.");
                Console.ReadLine();
                return;
            }

            if (IsSupportedCoordinates(lineCommand.StartPoint, lineCommand.EndPoint))
            {
                if (lineCommand.StartPoint.X == lineCommand.EndPoint.X)
                {
                    DrawVerticleLine(lineCommand.StartPoint, lineCommand.EndPoint, canvas);
                }
                else if (lineCommand.StartPoint.Y == lineCommand.EndPoint.Y)
                {
                    DrawHorizontalLine(lineCommand.StartPoint, lineCommand.EndPoint, canvas);
                }
            }
        }

        private bool IsSupportedCoordinates(Point startPoint, Point endPoint)
        {
            return startPoint.X == endPoint.X || endPoint.Y == endPoint.Y;
        }
    }
}