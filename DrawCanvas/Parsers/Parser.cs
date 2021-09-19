using DrawCanvas.Commands;
using DrawCanvas.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DrawCanvas.Parsers
{
    public class Parser : IParser
    {
        private string _commandText = string.Empty;

        public Parser(string commandText)
        {
            _commandText = commandText;
        }

        public string GetCommandText()
        {
            return _commandText;
        }

        public virtual IBaseCommand ParseCommand()
        {
            List<string> commandParams = _commandText.Split(' ').ToList();
            IBaseCommand command = new Command();

            command.CommandName = commandParams.First().First();
            command.CommandParams = commandParams.Skip(1).ToList();

            return command;
        }
    }
}