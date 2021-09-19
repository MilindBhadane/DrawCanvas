using DrawCanvas.Commands;
using DrawCanvas.Interfaces;

namespace DrawCanvas.Executors
{
    public class CmdCanvasExecutor : ICmdProcessor
    {
        public void ProcessCommand(IBaseCommand command, ref Canvas canvas)
        {
            CmdCanvas cmdCanvas = command as CmdCanvas;
            canvas = new Canvas(cmdCanvas.Width, cmdCanvas.Height);
        }
    }
}