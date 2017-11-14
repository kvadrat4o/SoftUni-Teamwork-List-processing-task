namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ListProcessing.Interfaces;
    using ListProcessing.Helpers;

    public class CountCommand : Command
    {
        private const int CmdArgsRequiredLengthLength = 2;

        public CountCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length != CmdArgsRequiredLengthLength)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            writer.WriteLine(data.Where(s => s == this.CmdArgs[1]).Count().ToString());
        }
    }
}
