namespace Gomoku
{
    public enum BoardState
    {
        Black = 0,
        White = 1,
        Empty = 2,
    }

    public sealed class Board
    {
        private readonly BoardState[,] _grid = new BoardState[15, 15];

        public BoardState this[int x, int y]
        {
            get => _grid[x, y];
            set => _grid[x, y] = value;
        }
        public GameState State { get; set; } = GameState.PlayerTurn;
        public void SetMove(int x, int y, BoardState state)
        {
            _grid[x, y] = state;
            State = (GameState)state;
        }

        public void Clean()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    this[i, j] = BoardState.Empty;
                }
            }
        }
    }
}