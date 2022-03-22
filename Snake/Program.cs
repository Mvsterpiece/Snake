﻿using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

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
			}
			Console.ReadLine();
		}
    }
}
