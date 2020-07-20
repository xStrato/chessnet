using System;
using chessnet.Game;
using chessnet.Game.World;

namespace chessnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Board board = new Board(8, 8);
            Window.PrintBoard(board);
        }
    }
}
