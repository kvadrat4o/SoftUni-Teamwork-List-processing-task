using ListProcessing.Interfaces;

namespace ListProcessing.Commands
{
    class RollRightCommand : Command
    {
        public RollRightCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
