using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System.Linq;

namespace DrawCanvas.Parsers
{
    public class ReactangleParser : Parser
    {
        public ReactangleParser(string commandText) : base(commandText)
        {
        }

        public override IBaseCommand ParseCommand()
        {
            IBaseCommand command = base.ParseCommand();
            CmdReactangle reactangleCommand = new CmdReactangle();

            string firstParam = command.CommandParams.Skip(0).First();
            string secondParam = command.CommandParams.Skip(1).First();
            string thirdParam = command.CommandParams.Skip(2).First();
            string fourthParam = command.CommandParams.Skip(3).First();

            reactangleCommand.CommandName = command.CommandName;
            reactangleCommand.CommandParams = command.CommandParams;

            int x1, y1, x2, y2;

            if (int.TryParse(firstParam, out x1) && int.TryParse(secondParam, out y1)
                && int.TryParse(thirdParam, out x2) && int.TryParse(fourthParam, out y2))
            {
                reactangleCommand.TopLeft = new System.Drawing.Point(x1, y1);
                reactangleCommand.RightBottom = new System.Drawing.Point(x2, y2);
            }

            return reactangleCommand;
        }
    }
}