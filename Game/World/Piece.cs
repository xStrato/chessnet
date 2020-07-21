namespace chessnet.Game.World
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            NumMoviments = 0;
        }

        public void IncrementMoviment() => NumMoviments++;
    }
}