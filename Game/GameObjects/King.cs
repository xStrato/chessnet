using chessnet.Game.World;

namespace chessnet.Game.GameObjects
{
    public class King: Piece
    {
        public King(Board board, Color color): base(board, color){}
        public override string ToString() => "R";
    }
}