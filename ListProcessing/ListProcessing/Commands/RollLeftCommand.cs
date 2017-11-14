namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using ListProcessing.Helpers;

    public class RollLeftCommand : Command
    {
        private const int CmdArgsRequiredLengthLength = 2;

        public RollLeftCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length > CmdArgsRequiredLengthLength)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            var firstItem = data[0];
            data.RemoveAt(0);
            data.Add(firstItem);

            writer.WriteLine(string.Join(" ", data));
        }
    }
}
