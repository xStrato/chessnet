using chessnet.Game.World;
using chessnet.Game.GameObjects;
using chessnet.Game.Rules;

namespace chessnet.Game.Rules
{
    public class Match
    {
        public Board Board { get; private set; }
        private int Turn { get; set; }
        private Color CurrentPlayer { get; set; }

        public Match()
        {
            Board = new Board(8, 8);
            Turn = 0;
            CurrentPlayer = Color.White;
            InitMatch();
        }

        public void MovePiece(Position origin, Position dest)
        {
            var piece = Board.RemovePiece(origin);
            piece.IncrementMoviment();
            var catchPiece = Board.RemovePiece(dest);
            Board.SetPieceAtPos(piece, dest);
        }

        private void InitMatch() 
        {
            Board.SetPieceAtPos(new King(Board, CurrentPlayer), new ChessPosition('c', 1).ToPosition());
        }
    }
}