using chessnet.Game.World;

namespace chessnet.Game.GameObjects
{
    public class Tower: Piece
    {
        public Tower(Board board, Color color): base(board, color){}
        public override string ToString() => "T";
    }
}