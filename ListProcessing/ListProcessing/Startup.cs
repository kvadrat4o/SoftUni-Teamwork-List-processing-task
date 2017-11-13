namespace ListProcessing
{
    using Controllers;
    using Interfaces;
    using IO;

    class Startup
    {
        static void Main()
        {
            var reader = new InputReader();
            var writer = new OutputWriter();
            var commandInterpreter = new CommandInterpreter<ICommand>();

            var engine = new Engine(reader, writer, commandInterpreter);
            engine.Run();
        }
    }
}
