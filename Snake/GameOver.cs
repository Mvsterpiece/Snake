using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	class GameOver
	{
		public void WriteGameOver() //метод который пишет в конце игры
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("____________________________", xOffset, yOffset++);
			WriteText("    G A M E    O V E R", xOffset + 1, yOffset++);
			WriteText("____________________________", xOffset, yOffset++);
		}
		static void WriteText(String text, int xOffset, int yOffset) //метод, написание текста
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}
