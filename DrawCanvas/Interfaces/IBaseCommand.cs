using System.Collections.Generic;

namespace DrawCanvas.Interfaces
{
    public interface IBaseCommand
    {
        char CommandName { get; set; }

        List<string> CommandParams { get; set; }
    }
}