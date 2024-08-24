using System;

namespace TicTacToeFacade
{
    public class ResultAnalyzer
    {
        private Board board;
        private ResultType result;

        // Constructor
        public ResultAnalyzer(Board board)
        {
            this.board = board;
            this.result = ResultType.PROGRESS;
        }

        // Method to analyze the result
        public ResultType AnalyzeResult(MarkType mark)
        {
            if (board.CheckWin(mark))
            {
                return ResultType.WIN;
            }

            if (board.IsBoardFull())
            {
                return ResultType.DRAW;
            }

            return ResultType.PROGRESS;
        }
    }
}
