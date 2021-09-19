using DrawCanvas.Interfaces;

namespace DrawCanvas.Executors
{
    public class CmdExecutorFactory
    {
        public static ICmdProcessor GetCommandProcessor(IBaseCommand command)
        {
            ICmdProcessor commandProcessor = null;

            switch (command.CommandName)
            {
                case CommonUtils.Canvas:
                    commandProcessor = new CmdCanvasExecutor();
                    break;

                case CommonUtils.Line:
                    commandProcessor = new CmdLineExecutor();
                    break;

                case CommonUtils.Reactangle:
                    commandProcessor = new CmdRectangleExecutor();
                    break;

                case CommonUtils.BackColor:
                    commandProcessor = new CmdBackColorExecutor();
                    break;

                default: break;
            }

            return commandProcessor;
        }
    }
}