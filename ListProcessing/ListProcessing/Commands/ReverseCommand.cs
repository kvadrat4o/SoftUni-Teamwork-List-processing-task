namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ListProcessing.Interfaces;

    public  class ReverseCommand : Command
    {
        public ReverseCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
           writer.WriteLine(string.Join(" ",data.Reverse()));
        }
    }
}
