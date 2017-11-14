namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ListProcessing.Interfaces;
    using ListProcessing.Helpers;

    public class CountCommand : Command
    {
        public CountCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length < 2)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            writer.WriteLine(data.Where(s => s == this.CmdArgs[1]).Count().ToString());
        }
    }
}
