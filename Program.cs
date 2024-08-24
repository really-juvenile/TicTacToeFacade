
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFacade
{


    public class Program
    {
        public static void Main()
        {
            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);
            Game game = new Game(player1, player2);

            while (true)
            {
                Console.Clear();
                game.DisplayBoard();
                Console.WriteLine($"Player {game.GetCurrentPlayer().GetMark()}'s turn. Enter location (0-8): ");
                int location;
                if (int.TryParse(Console.ReadLine(), out location))
                {
                    try
                    {
                        game.Play(location);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 8.");
                }
            }
        }
    }
}