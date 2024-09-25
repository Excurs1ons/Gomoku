namespace Gomoku.AI
{
    public class GomokuEvaluator : IEvaluator<Board,Move>
    {
        public float Evaluate(Board board)
        {
            var score = 0f;

            for (int x = 0; x < 15; x++)
            {
                score += EvaluateColumn(board, x, board.State);
                score += EvaluateRow(board, x, board.State);
                for (int y = 0; y < 15; y++)
                {
                    score += EvaluateDiagonal(board, x, y, board.State);
                }
            }

            return score;
        }

        private static float EvaluateRow(Board board, int row, GameState player)
        {
            return 0;
        }

        private static float EvaluateColumn(Board board, int column, GameState player)
        {
            return 0;
        }

        private static float EvaluateDiagonal(Board board, int row, int column, GameState player)
        {
            return 0;
        }

        public float Evaluate(Board board, Move move)
        {
            var score = 0f;

            for (int x = 0; x < 15; x++)
            {
                score += EvaluateColumn(board, x, board.State);
                score += EvaluateRow(board, x, board.State);
                for (int y = 0; y < 15; y++)
                {
                    score += EvaluateDiagonal(board, x, y, board.State);
                }
            }

            return score;
        }
    }
}