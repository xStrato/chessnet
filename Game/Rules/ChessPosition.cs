using chessnet.Game.World;

namespace chessnet.Game.Rules
{
    public class ChessPosition
    {
        public char Column { get; set; }
        public int Row { get; set; }

        public ChessPosition(char column, int row)
        {
            Row = row;
            Column = column;
        }
        public Position ToPosition() => new Position(8 - Row, Column - 'a');
        public override string ToString() => $" {Column}, {Row}";
    }
}