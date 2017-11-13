namespace ListProcessing.Interfaces
{
    public interface ICommandInterpreter<T> 
        where T : class
    {
        T ExecuteCommand(string[] args, int cmdNameWordCount = 1);
    }
}
