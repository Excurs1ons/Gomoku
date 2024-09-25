using System;

namespace Gomoku
{
    public class ConsoleController : IController
    {
        private readonly GameModel _model;
        private readonly IView _view;
        
        public int[] GetPlayerInput()
        {
            var str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return null;
            var input = str.Split(',');
            if (input.Length != 2) return null;
            if (!uint.TryParse(input[0], out var x)) return null;
            if (!uint.TryParse(input[1], out var y)) return null;
            if (x > 14 || y > 14) return null;
            return new[] { (int)x, (int)y };
        }

        public ConsoleController(GameModel model, IView view)
        {
            _model = model;
            _view = view;
        }
        
        
    }

    public enum GameState
    {
        PlayerTurn = 0,
        ComputerTurn = 1,
        GameOver = 2
    }
}