using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	class Score
	{
        private int score;
        public int level;
        public int speed;
        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public bool ScoreUp()//Увеличение Score
        {
            score += 1;
            if (score % 10 == 0)//Обозначние Score на 1 уровень
            {
                level += 1;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(70, 1);
            Console.WriteLine("Score:" + score.ToString());
            Console.SetCursorPosition(70, 2);
            Console.WriteLine("Level:" + level.ToString());
        }
    }
}
