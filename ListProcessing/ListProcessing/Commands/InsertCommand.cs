using System;
using System.Collections.Generic;
using System.Text;
using ListProcessing.Helpers;

namespace ListProcessing.Commands
{
    using ListProcessing.Interfaces;

    public class InsertCommand : Command
    {
        public InsertCommand(string[] cmdArgs)
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
                if (this.CmdArgs.Length != 3)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
                }
                data.Insert(index, this.CmdArgs[2]);
                writer.WriteLine(string.Join(" ", data));
                
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

        }
    }
}
