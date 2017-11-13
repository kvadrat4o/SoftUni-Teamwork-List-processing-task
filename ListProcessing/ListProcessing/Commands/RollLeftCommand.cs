using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
    public class RollLeftCommand : Command
    {
        public RollLeftCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
