namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using ListProcessing.Helpers;

    public class EndCommand : Command
    {
        private const string TerminatingCommand = "end";
        private const string SuccessExecutionMessage = "Finished";

        public EndCommand(string[] cmdArgs) 
            : base(cmdArgs)
        {
        }

        public override void Execute(IOutputWriter writer, IList<string> data)
        {
            if (this.CmdArgs.Length > 1)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            if (this.CmdArgs[0] == TerminatingCommand)
            {
                writer.WriteLine(SuccessExecutionMessage);
                Environment.Exit(Environment.ExitCode);
            }

            throw new ArgumentException(ExceptionMessages.InvalidCommandExceptionMessage);
        }
    }
}
