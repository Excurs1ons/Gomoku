namespace Gomoku.AI
{
    //博弈树
    public abstract class GameTree<TState, TChange>
    {
        private GameTreeNode<TState,TChange> _root;
        private IEvaluator<TState, TChange> _evaluator;
        private TState state;

        public GameTree(IEvaluator<TState, TChange> evaluator,TState state)
        {
            _root = new GameTreeNode<TState, TChange>(evaluator,null);
        }

        public void MiniMaxSearch(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
            }
        }
    }
}