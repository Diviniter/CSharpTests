using ClassLibrary;
using System;

namespace ConsoleApplication
{
    public class ConsoleWriter : OutputWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
