using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade
{
    public class Board
    {
        private readonly MarkType[,] cells = new MarkType[3, 3];

        public Board()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    cells[row, col] = MarkType.EMPTY;
                }
            }
        }

        public MarkType GetCellAt(int row , int col)
        {
            return cells[row, col]; 
        }

        public bool SetCellAt(int row, int col, MarkType cellType)
        {
            if(cells[row, col] != MarkType.EMPTY)
                throw new CellAlreadyMarkedException("Cell at row " + row + " and column " + col + " is already marked.");
            cells[row, col] = cellType;
            return true;
        }

        public bool IsBoardFull()
        {
            foreach (var cell in cells)
            {
                if (cell == MarkType.EMPTY)
                    return false;
            }
            return true;
        }

        public MarkType GetCellMark(int loc)
        {
            int row = loc / 3;
            int col = loc % 3;
            return cells[row, col];
        }

        public bool SetCellMark(int loc, MarkType mark)
        {
            int row = loc / 3;
            int col = loc % 3;
            if (cells[row, col] != MarkType.EMPTY)
            {
                throw new CellAlreadyMarkedException("The cell is already marked.");
            }
            return SetCellAt(row, col, mark);
        }

        public bool CheckWin(MarkType cellType)
        {
            for (int row = 0; row < 3; row++)
            {
                if (cells[row, 0] == cellType && cells[row, 1] == cellType && cells[row, 2] == cellType)
                    return true;
            }

            for (int col = 0; col < 3; col++)
            {
                if (cells[0, col] == cellType && cells[1, col] == cellType && cells[2, col] == cellType)
                    return true;
            }

            if (cells[0, 0] == cellType && cells[1, 1] == cellType && cells[2, 2] == cellType)
                return true;
            if (cells[0, 2] == cellType && cells[1, 1] == cellType && cells[2, 0] == cellType)
                return true;

            return false;
        }

        public void PrintBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(cells[row, col] == MarkType.EMPTY ? "-" : cells[row, col].ToString());
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
