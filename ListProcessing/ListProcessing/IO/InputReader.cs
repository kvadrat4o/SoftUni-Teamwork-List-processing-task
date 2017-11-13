namespace ListProcessing.IO
{
    using System;
    using Interfaces;

    public class InputReader : IInputReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
