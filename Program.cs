using static System.Console;
using chessnet.Game;
using chessnet.Game.World;
using chessnet.Game.Rules;
using chessnet.Game.GameObjects;

namespace chessnet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var match = new Match();
                
                Window.PrintBoard(match.Board);
            }
            catch (System.Exception err)
            {
                WriteLine(err.Message);
            }
            // ReadLine();
        }
    }
}
