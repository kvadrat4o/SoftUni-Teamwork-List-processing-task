namespace ListProcessing.Controllers
{
    using Interfaces;
    using System;
    using System.Linq;

    public class Engine
    {
        private IInputReader reader;
        private IOutputWriter writer;
        private ICommandInterpreter<ICommand> commandInterpreter;

        public Engine(IInputReader reader, IOutputWriter writer, ICommandInterpreter<ICommand> commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;
        }

        public void Run() => this.ProcessCommandsFomUser();

        private void ProcessCommandsFomUser()
        {
            var data = this.reader.ReadLine()
                .Split()
                .ToList();

            while (true) // Termination logic is in ExitCommand
            {
                var input = this.reader.ReadLine().Split();
                var command = this.commandInterpreter.ExecuteCommand(input);

                try
                {
                    command.Execute(this.writer, data);
                }
                catch (ArgumentException ae)
                {
                    this.writer.WriteLine(ae.Message);
                }
            }
        }
    }
}
