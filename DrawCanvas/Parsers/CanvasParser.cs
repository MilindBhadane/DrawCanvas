using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System.Linq;

namespace DrawCanvas.Parsers
{
    public class CanvasParser : Parser
    {
        public CanvasParser(string commandText) : base(commandText)
        {
        }

        public override IBaseCommand ParseCommand()
        {
            IBaseCommand command = base.ParseCommand();
            CmdCanvas cmdCanvas = new CmdCanvas();

            cmdCanvas.CommandName = command.CommandName;
            cmdCanvas.CommandParams = command.CommandParams;

            string firstParam = command.CommandParams.Skip(0).First();
            string secondParam = command.CommandParams.Skip(1).First();

            int x1, y1;
            if (int.TryParse(firstParam, out x1) && int.TryParse(secondParam, out y1))
            {
                cmdCanvas.Width = x1;
                cmdCanvas.Height = y1;
            }
            return cmdCanvas;
        }
    }
}