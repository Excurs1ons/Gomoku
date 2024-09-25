using System;

namespace Gomoku
{
    public struct Move
    {
        public readonly int X;
        public readonly int Y;
        public BoardState Player;

        public Move(int x, int y, BoardState player)
        {
            if (x < 0 || x > 14 || y < 0 || y > 14) throw new Exception("input move is out of range");
            if (player == BoardState.Empty) throw new Exception("input move is empty");
            X = x;
            Y = y;
            Player = player;
        }
    }
}