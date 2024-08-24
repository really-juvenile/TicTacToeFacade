
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade
{
    public class Location
    {
        public int Row { get; }
        public int Column { get; }

        public Location(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int ToIndex()
        {
            return Row * 3 + Column;
        }

        public static Location FromIndex(int index)
        {
            int row = index / 3;
            int column = index % 3;
            return new Location(row, column);
        }
    }
}