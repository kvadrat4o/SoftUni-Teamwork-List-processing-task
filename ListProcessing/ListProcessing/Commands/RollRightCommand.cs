namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using ListProcessing.Helpers;

    class RollRightCommand : Command
    {
        private const int CmdArgsRequiredLengthLength = 2;

        public RollRightCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length > CmdArgsRequiredLengthLength)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            data.Insert(0, data[data.Count - 1]);
            data.RemoveAt(data.Count - 1);

            writer.WriteLine(string.Join(" ", data));
        }
    }
}
