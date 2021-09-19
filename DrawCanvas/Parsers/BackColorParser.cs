using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System.Drawing;
using System.Linq;

namespace DrawCanvas.Parsers
{
    public class BackColorParser : Parser
    {
        public BackColorParser(string commandText) : base(commandText)
        {
        }

        public override IBaseCommand ParseCommand()
        {
            IBaseCommand command = base.ParseCommand();
            CmdBackColor cmdBackColor = new CmdBackColor();

            string firstParam = command.CommandParams.Skip(0).First();
            string secondParam = command.CommandParams.Skip(1).First();
            char charToPrint = command.CommandParams.Skip(2).First().First();

            cmdBackColor.CommandName = command.CommandName;
            cmdBackColor.CommandParams = command.CommandParams;

            int x1, y1;

            if (int.TryParse(firstParam, out x1) && int.TryParse(secondParam, out y1))
            {
                cmdBackColor.CharToPrint = charToPrint;
                cmdBackColor.Point = new Point(x1, y1);
            }

            return cmdBackColor;
        }
    }
}