using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point StartPoint = new Point(4,5,'*');
            Snake snake = new Snake(StartPoint, 4, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                     
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

      
    }
}
