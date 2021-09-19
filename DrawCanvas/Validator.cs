using DrawCanvas.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DrawCanvas
{
    public static class Validator
    {
        public static List<string> ValidationErrors { get; set; }
        public static List<char> AllCommands { get; set; }

        private static Dictionary<char, int> CommandValidators = new Dictionary<char, int>();

        static Validator()
        {
            ParametersCountValidator();
        }

        public static List<string> ValidateCommand(IBaseCommand command)
        {
            List<string> errors = new List<string>();

            if (!Validate(command))
            {
                errors.AddRange(ValidationErrors);
            }
            return errors;
        }

        public static void ParametersCountValidator()
        {
            ValidationErrors = new List<string>();

            AllCommands = new List<char> {
                CommonUtils.Canvas,
                CommonUtils.Line,
                CommonUtils.Reactangle,
                CommonUtils.Quit,
                CommonUtils.BackColor };

            LoadParamsCountRules();
        }

        private static void LoadParamsCountRules()
        {
            CommandValidators.Add(CommonUtils.Canvas, 2);
            CommandValidators.Add(CommonUtils.Line, 4);
            CommandValidators.Add(CommonUtils.Reactangle, 4);
            CommandValidators.Add(CommonUtils.BackColor, 3);
            CommandValidators.Add(CommonUtils.Quit, 0);
        }

        public static bool Validate(IBaseCommand command)
        {
            if (!AllCommands.Contains(command.CommandName))
            {
                return true;
            }

            if (CommandValidators.Any(item => item.Key == command.CommandName))
            {
                var args = CommandValidators.FirstOrDefault(item => item.Key == command.CommandName);
                if (args.Value == command.CommandParams.Count)
                {
                    return true;
                }
                else
                {
                    ValidationErrors.Add(string.Format("Invalid arguments provided for command : {0}", command.CommandName));
                }
            }
            return false;
        }
    }
}