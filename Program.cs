namespace Gomoku
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new GomokuGame();

            while (game.IsRunning)
            {
                game.Tick();
            }
        }
    }
}