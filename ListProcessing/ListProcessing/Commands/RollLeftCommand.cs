namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;

    public class RollLeftCommand : Command
    {
        public RollLeftCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            var firstItem = data[0];
            data.RemoveAt(0);
            data.Add(firstItem);

            writer.WriteLine(string.Join(" ", data));
        }
    }
}
