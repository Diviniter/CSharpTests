using System;

namespace ClassLibrary
{
    public class Human
    {
        private readonly OutputWriter outputWriter;

        public Human(OutputWriter outputWriter)
        {
            this.outputWriter = outputWriter;
        }

        public void Say(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("The message can't be empty");

            this.outputWriter.Write(message);
        }
    }
}
