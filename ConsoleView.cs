using System;
using System.Collections;

namespace Gomoku
{
    public class ConsoleView : IView
    {
        
        public void Refresh(GameModel model)
        {
            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (model.GetMove(x, y) == BoardState.Empty)
                    {
                        Console.Write(" + ");
                        continue;
                    }
                    Console.Write(model.GetMove(x, y) == BoardState.Black ? " \u25cf " : " \u25cb ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");
        }
    }
}