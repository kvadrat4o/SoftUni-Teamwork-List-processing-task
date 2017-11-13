namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;

    public class StartCommand : Command
    {
        public StartCommand(string[] cmdArgs) : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            writer.WriteLine(string.Join(" ",this.CmdArgs));
        }
    }
}
