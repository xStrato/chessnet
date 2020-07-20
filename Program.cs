using static System.Console;
using chessnet.Game;
using chessnet.Game.World;
using chessnet.Game.GameObjects;

namespace chessnet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.SetPieceAtPos(new Tower(board, Color.Grey), new Position(0, 0));
                board.SetPieceAtPos(new Tower(board, Color.Grey), new Position(0, 5));
                board.SetPieceAtPos(new Tower(board, Color.Grey), new Position(0, 9));
                
                Window.PrintBoard(board);
            }
            catch (System.Exception err)
            {
                WriteLine(err.Message);
            }
        }
    }
}
