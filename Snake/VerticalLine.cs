using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class VerticalLine : Figure
    {
		public VerticalLine(int yUp, int yDown, int x, char sym)//конструктор для место расположения точки на оси Y
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
