namespace chessnet.Game.World
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }
        public Piece Piece(int row, int column) => Pieces[row, column];
        public void SetPieceAtPos(Piece piece, Position pos) 
        {
            Pieces[pos.Row, pos.Column] = piece;
            piece.Position = pos;
        }
    }
}