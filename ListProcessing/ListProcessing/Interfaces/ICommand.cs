namespace ListProcessing.Interfaces
{
    using System.Collections.Generic;

    public interface ICommand
    {
        string[] CmdArgs { get; set; }

        void Execute(IOutputWriter writer, IList<string> data);
    }
}
