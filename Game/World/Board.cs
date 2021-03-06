using chessnet.Game.World.WorldsExceptions;

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
        public Piece GetPiece(int row, int column) => Pieces[row, column];
        public Piece GetPiece(Position pos) => Pieces[pos.Row, pos.Column];
        public bool InvalidEntry(Position pos) => (pos.Row < 0 || pos.Row >= Rows) && (pos.Column < 0 || pos.Column >= Columns);
        public bool HasPieceAt(Position pos) => !InvalidEntry(pos) && GetPiece(pos) != null;
        public void SetPieceAtPos(Piece piece, Position pos) 
        {
            if (HasPieceAt(pos))
            {
                throw new BoardException("Invalid entry or already has a piece at same position!");
            }
            Pieces[pos.Row, pos.Column] = piece;
            piece.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(HasPieceAt(pos)) { return null; };

            var aux = GetPiece(pos);
            aux.Position = null;
            Pieces[pos.Row, pos.Column] = null;
            return aux;
        }
    }
}