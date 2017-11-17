namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using ListProcessing.Helpers;

    public class AppendCommand : Command
    {
        public AppendCommand(string[] cmdArgs)
            :base(cmdArgs)
        {

        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length != 2)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            data.Add(this.CmdArgs[1]);
            writer.WriteLine(String.Join(" ",data));
        }
    }
}
