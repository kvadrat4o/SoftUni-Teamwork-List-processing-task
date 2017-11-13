namespace ListProcessing.IO
{
    using System;
    using ListProcessing.Interfaces;

    public class OutputWriter : IOutputWriter
    {
        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
