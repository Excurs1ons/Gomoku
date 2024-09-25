using System.Collections.Generic;

namespace Gomoku
{
    public class GameModel
    {





        public readonly Board Board = new Board();
        private List<Move> _moves = new List<Move>();


        public bool IsValidMove(Move move)
        {
            return Board[move.X, move.Y] == BoardState.Empty;
        }



        public BoardState GetMove(int x, int y) => Board[x, y];
        
        public void Start()
        {
            Board.Clean();
        }
    }

}