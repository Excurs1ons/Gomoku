namespace Gomoku.AI
{
    public class GomokuGameTree : GameTree<Board, Move>
    {
        public GomokuGameTree(IEvaluator<Board, Move> evaluator,Board board) : base(evaluator,board)
        {
        }
    }
}