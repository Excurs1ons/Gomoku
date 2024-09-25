using System.Collections.Generic;
using System.Linq;

namespace Gomoku.AI
{
    public class GameTreeNode<TState, TChange>
    {
        private IEvaluator<TState, TChange> _evaluator;
        public List<GameTreeNode<TState, TChange>> _children;

        public GameTreeNode()
        {
            _children = new List<GameTreeNode<TState, TChange>>();
        }

        public GameTreeNode<TState, TChange> _parent;
        public float _score;

        public GameTreeNode(IEvaluator<TState, TChange> evaluator, GameTreeNode<TState, TChange> parent)
        {
            _evaluator = evaluator;
            _parent = parent;
            _children = new List<GameTreeNode<TState, TChange>>();
        }

        public float Evaluate()
        {
            return this.Evaluate() + _children.Sum(child => child.Evaluate());
        }
    }
}