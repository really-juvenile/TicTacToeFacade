using System;

namespace TicTacToeFacade
{
    public class Game
    {
        private Board board;
        private ResultAnalyzer resultAnalyzer;
        private Player currentPlayer;
        private Player player1;
        private Player player2;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            board = new Board();
            resultAnalyzer = new ResultAnalyzer(board);
            currentPlayer = player1; // Start with player 1
        }

        public void Play(int location)
        {
            try
            {
                if (location < 0 || location > 8)
                {
                    throw new InvalidInputException("Invalid location! Please enter a number between 0 and 8.");
                }

                if (board.SetCellMark(location, currentPlayer.GetMark()))
                {
                    ResultType result = resultAnalyzer.AnalyzeResult(currentPlayer.GetMark());

                    if (result == ResultType.PROGRESS)
                    {
                        SwapPlayers();
                    }
                    else
                    {
                        board.PrintBoard();
                        if (result == ResultType.WIN)
                        {
                            Console.WriteLine($"Player {currentPlayer.GetMark()} wins!");
                        }
                        else if (result == ResultType.DRAW)
                        {
                            Console.WriteLine("The game is a draw!");
                        }
                        Environment.Exit(0); // End the game
                    }
                }
            }
            catch (CellAlreadyMarkedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

        private void SwapPlayers()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }

        public void DisplayBoard()
        {
            board.PrintBoard();
        }

        public Player GetCurrentPlayer()
        {
            return currentPlayer;
        }
    }
}
