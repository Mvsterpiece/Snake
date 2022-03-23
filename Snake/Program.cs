using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Snake";
			Console.SetBufferSize(120, 75);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек	
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			//Появление в рандомном месте точки(еды)
			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			Score score = new Score(0, 1);
			score.ScoreUp();

			//Рандомный спавн точек(еды)
			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
					score.ScoreUp();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
					if (Console.KeyAvailable)
					{
						ConsoleKeyInfo key = Console.ReadKey(true);
						snake.HandleKey(key.Key);
					}
			}
			GameOver end = new GameOver();
			end.WriteGameOver();

			Console.ReadLine();
		}
    }
}
