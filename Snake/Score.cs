using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	public class Score
	{
        private int score;
        public int level;
        public int speed;
        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public void ScoreUp()//Увеличение Score
        {
            Console.SetCursorPosition(81, 12);
            Console.WriteLine("Score:" + score.ToString());
            score++;
        }
    }
}
