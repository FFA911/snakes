using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VertikalLine Leftline = new VertikalLine(0, 24, 0, '+');
            VertikalLine Rightline = new VertikalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            Rightline.Drow();
            Leftline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

           while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow && snake.direction != Direction.RIGHT)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow && snake.direction != Direction.LEFT)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow && snake.direction != Direction.UP)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow && snake.direction != Direction.DOWN)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }
    }
    }
}
