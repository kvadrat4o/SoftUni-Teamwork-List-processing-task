namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;

    class RollRightCommand : Command
    {
        public RollRightCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            data.Insert(0, data[data.Count - 1]);
            data.RemoveAt(data.Count - 1);

            writer.WriteLine(string.Join(" ", data));
        }
    }
}
