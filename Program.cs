using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLib.Model;
namespace TDDTicTacToeSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] p = new Player[2];
            Console.WriteLine("PLAY TIC TAC TOE GAME !!");
            Console.WriteLine("First Player Name: ");
            string p1=Console.ReadLine();
            Console.WriteLine("Second Player Name: ");
            string p2 = Console.ReadLine();
            p[0] = new Player(p1, MarkType.O);
            p[1] = new Player(p2, MarkType.X);
            Console.WriteLine(p[0].Name + " Mark Sign: " + p[0].Mark);
            Console.WriteLine(p[1].Name + " Mark Sign: " + p[1].Mark);
            Board board = new Board(new Cell[9]);
            Game game = new Game(p,board,new ResultAnalyzer(board));
            while (game.Status == ResultType.NO_RESULT)
            {
                Console.WriteLine("\n{0} Turn:Enter Position ", game.CurrentPlayer.Name);
                int playerLoc = Convert.ToInt32(Console.ReadLine());
                game.Play(playerLoc - 1);
                ShowBoard(board.getBoard);
            }
            if (game.Status == ResultType.WIN)
            {
                Console.WriteLine("\nCongratulation!! {0} WON the Game. ", game.CurrentPlayer.Name);
            }
            if(game.Status == ResultType.DRAW)
            {
                Console.WriteLine("Game DRAW , Try Again !!");
            }
            Console.ReadKey();
        }
        public static void ShowBoard(Cell[] cell)
        {
            for (int i = 0; i < cell.Length; i++)
            {
                if (i == 3 || i == 6) { Console.WriteLine(); }
                if (cell[i].getMark() == MarkType.EMPTY) { Console.Write(" "); }
                else { Console.Write(cell[i].getMark()); }
                if (!(i == 2 || i == 5 || i == 8)) { Console.Write("|"); }

            }
        }
    }
}
