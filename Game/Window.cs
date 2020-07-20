using chessnet.Game.World;
using static System.Console;
using static System.ConsoleColor;

namespace chessnet.Game
{
    public class Window
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Write(8 - i +" ");
                for (int j = 0; j < board.Columns; j++)
                {
                    if(board.Piece(i, j) == null){Write("- ");} 
                    else{PrintPiece(board.Piece(i, j)); Write(" ");}
                }
                WriteLine();
            }
            WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White){Write(piece);}
            else 
            {
                var aux = ForegroundColor;
                ForegroundColor = Yellow;
                Write(piece);
                ForegroundColor = aux;
            }
        }
    }
}