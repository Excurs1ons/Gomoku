namespace Gomoku
{
    public static class GameExtensions
    {
        public static void ShutDown(this ISystem system)
        {
            system.End();
        }
    }
}