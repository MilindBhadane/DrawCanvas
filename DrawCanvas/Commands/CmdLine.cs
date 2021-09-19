using System.Drawing;

namespace DrawCanvas.Commands
{
    public class CmdLine : Command
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
    }
}