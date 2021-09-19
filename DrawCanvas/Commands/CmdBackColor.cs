using System.Drawing;

namespace DrawCanvas.Commands
{
    public class CmdBackColor : Command
    {
        public Point Point { get; set; }
        public char CharToPrint { get; set; }
    }
}