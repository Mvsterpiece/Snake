using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Figure
    {
		protected List<Point> pList;

		public void Draw() //метод прорисовки точек
		{
			foreach (Point p in pList) //проприсовывает значение из списка
			{
				p.Draw();
			}
		}

		internal bool IsHit(Figure figure) //метод столкновения змейки с препятствием
		{
			foreach (var p in pList) //берет значение из списка 
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)//метод для провервки столкновения с точкой(если змейка сама с собой столкнется)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
