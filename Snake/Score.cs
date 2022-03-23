using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	public class Score
	{
        private int score;
        public int level;
        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public void ScoreUp()//Увеличение Score
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(70, 0);
            Console.WriteLine("Score:" + score.ToString());
            score++;
        }
    }
}
