namespace ListProcessing.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Helpers;

    public class CommandInterpreter<T> : ICommandInterpreter<T> 
        where T : class
    {
        private IEnumerable<Type> commands;

        public CommandInterpreter()
            : this(new TypeCollector())
        {
        }

        public CommandInterpreter(ITypeCollector typeCollector)
            : this(typeCollector.GetAllInheritingTypes<T>())
        {
        }

        public CommandInterpreter(IEnumerable<Type> commands)
        {
            this.commands = commands;
        }

        public T ExecuteCommand(string[] cmdArgs, int cmdNameWordCount = 1)
        {
            if (cmdArgs.Length < cmdNameWordCount)
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandParametersExceptionMessage);
            }

            var cmdName = string.Join("", cmdArgs.Take(cmdNameWordCount));

            var commands = this.commands
                .Where(c => c.Name.StartsWith(cmdName, StringComparison.OrdinalIgnoreCase))
                .ToArray();

            if (commands == null) // Wrong name
            {
                throw new ArgumentException(ExceptionMessages.InvalidCommandExceptionMessage);
            }

            // Check if command name is more than one word
            if (commands.Length > 1)
            {
                cmdNameWordCount++;
                return this.ExecuteCommand(cmdArgs, cmdNameWordCount);
            }

            var commandType = commands[0];

            // Create Instance
            var cmd = (T)Activator.CreateInstance(commandType, new[] { cmdArgs });
            return cmd;
        }
    }
}
