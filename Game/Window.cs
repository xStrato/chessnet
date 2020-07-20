using chessnet.Game.World;
using static System.Console;

namespace chessnet.Game
{
    public class Window
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if(board.Piece(i, j) == null){Write("-- ");} 
                    else{Write(board.Piece(i, j));}
                }
                WriteLine();
            }
        }
    }
}