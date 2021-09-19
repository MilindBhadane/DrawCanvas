using DrawCanvas.Interfaces;
using System.Collections.Generic;

namespace DrawCanvas.Commands
{
    public class Command : IBaseCommand
    {
        public char CommandName { get; set; }

        public List<string> CommandParams { get; set; }
    }
}