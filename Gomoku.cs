using System;
using System.Collections.Generic;

namespace Gomoku
{
    public sealed class GomokuGame : GameBase
    {

        private GameModel _model;
        private IView _view;
        private IController _controller;

        public GomokuGame()
        {
            Init();
        }


        protected override void Init()
        {
            _model = new GameModel();
            _view = new ConsoleView();
            _controller = new ConsoleController(_model, _view);
            base.Init();
        }

        public override void Tick()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            GetNextMove();
            base.Tick();
        }

        public override void End()
        {
            Console.WriteLine("Game Over");
            base.End();
        }

        public int[] GetNextMove()
        {
            if (_model.Board.State == GameState.PlayerTurn)
            {
                Console.WriteLine("Your turn: Input as \"X,Y\"");
                return _controller.GetPlayerInput();
            } 
            return GetComputerInput();
        }

        private int[] GetComputerInput()
        {
            return null;
        }

        ~GomokuGame()
        {
            End();
        }
    }
}