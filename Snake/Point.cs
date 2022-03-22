using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
		public int x;
		public int y;
		public char sym;

		public Point(int x, int y, char sym) //конструктор для создания точки, который берет 2 позиции на оси координат и символ точки 
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)//конструктор, который позволяет обновлять месторасположение точки
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)//метод движения
		{
			if (direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()//метод для прорисовки точки
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear()//метод очистки точки или же остановки змейки
		{
			sym = ' ';
			Draw();
		}
	}
}
