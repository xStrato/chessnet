using System;

namespace chessnet.Game.World.WorldsExceptions
{
    public class BoardException: ApplicationException
    {
        public BoardException(string message): base(message){}
    }
}