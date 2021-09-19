namespace DrawCanvas.Interfaces
{
    public interface ICmdProcessor
    {
        void ProcessCommand(IBaseCommand command, ref Canvas canvas);
    }
}