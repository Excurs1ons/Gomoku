namespace Gomoku.AI
{
    public interface IEvaluator<TState, TChange>
    {
        float Evaluate(TState state, TChange change);
    }
}