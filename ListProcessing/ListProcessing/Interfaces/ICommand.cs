namespace ListProcessing.Interfaces
{
    public interface ICommand
    {
        string[] CmdArgs { get; set; }

        void Execute(IOutputWriter writer);
    }
}
