﻿

namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using ListProcessing.Helpers;
    using System.Linq;

    public class SortCommand: Command
    {
        public SortCommand(string[] cmdArgs)
            :base(cmdArgs)
        {

        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length != 1)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }
            
            data = data.OrderBy(s => s).ToList();
            writer.WriteLine(String.Join(" ", data));
        }
    }
}
