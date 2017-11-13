namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using ListProcessing.Helpers;
    using ListProcessing.Interfaces;

    public class DeleteCommand : Command
    {
        public DeleteCommand(string[] cmdArgs)
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            int index;

            bool validParse = int.TryParse(this.CmdArgs[1], out index);

            if (validParse)
            {
                if (index < 0 || index >= data.Count)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidCommandInsertExceptionMessage, this.CmdArgs[1]));


                }
                if (this.CmdArgs.Length != 2)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
                }
                data.RemoveAt(index);
                writer.WriteLine(string.Join(" ", data));

            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }
        }
    }
}
