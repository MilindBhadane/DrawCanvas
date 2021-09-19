using DrawCanvas.Interfaces;
using System.Drawing;

namespace DrawCanvas.Commands
{
    public class CmdReactangle : Command, IBaseCommand
    {
        public Point TopLeft { get; set; }

        public Point RightBottom { get; set; }
    }
}