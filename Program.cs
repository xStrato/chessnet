using System;
using chessnet.Game;
using chessnet.Game.World;
using chessnet.Game.GameObjects;

namespace chessnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Board board = new Board(8, 8);

            board.SetPieceAtPos(new Tower(board, Color.Grey), new Position(5, 2));
            Window.PrintBoard(board);
        }
    }
}
