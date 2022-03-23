using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
	class Score
	{
        private int score;
        public int speed;
        public Score(int score)
        {
            this.score = score;
        }
        public bool ScoreUp()//Увеличение Score
        {
            score += 1;
            if (score % 10 == 0)//Обозначние Score на 1 уровень
            {
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(70, 1);
            Console.WriteLine("Score:" + score.ToString());
        }
    }
}
