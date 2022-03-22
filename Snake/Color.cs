using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	class Color
	{
		public static Random rnd = new Random();
		public static ConsoleColor GetRandomConsoleColor()//Изменение цвета точек(змейки) в рандомные
		{
			var consoleColors = Enum.GetValues(typeof(ConsoleColor));
			return (ConsoleColor)consoleColors.GetValue(rnd.Next(1, consoleColors.Length));
		}
	}
}
