using System;

namespace TicTacToeFacade
{
    public class CellAlreadyMarkedException : Exception
    {
        public CellAlreadyMarkedException() : base("The cell is already marked.")
        {
        }

        public CellAlreadyMarkedException(string message) : base(message)
        {
        }

        public CellAlreadyMarkedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
