using System;

namespace TicTacToeFacade
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("Invalid input provided.")
        {
        }

        public InvalidInputException(string message) : base(message)
        {
        }

        public InvalidInputException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
