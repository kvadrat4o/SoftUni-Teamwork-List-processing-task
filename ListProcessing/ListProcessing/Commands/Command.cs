namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using Interfaces;

    public abstract class Command : ICommand
    {
        public Command(string[] cmdArgs)
        {
            CmdArgs = cmdArgs;
        }

        public string[] CmdArgs { get; set; }

        public abstract void Execute(IOutputWriter writer, IList<string> data);
    }
}
