using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
		public HorizontalLine(int xLeft, int xRight, int y, char sym)//конструктор для место расположения точки на оси X
		{
			pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}
	}
}
