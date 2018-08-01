using ClassLibrary;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputWriter = new ConsoleWriter();

            var john = new Human(outputWriter);
            john.Say("hello");

            Console.Read();
        }
    }
}
