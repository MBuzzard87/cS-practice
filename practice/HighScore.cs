using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class HighScore
    {


       


        public int Score { get; set; }
        
        public string HighScorePlayer { get; set; }

        public HighScore() { }

        public HighScore(int score, string highScorePlayer)
        {
            Score = score;
            HighScorePlayer = highScorePlayer;
        }


        public HighScore bestStudent(HighScore student1, HighScore student2, HighScore student3)
        {
            if(student1.Score > student2.Score)
            {
                if(student1.Score > student3.Score)
                {
                    return student1;
                } else
                {
                    return student3;
                }
            } else
            {
                if(student2.Score > student3.Score)
                {
                    return student2;
                } else
                {
                    return student3;
                }
            }

        }



    }
}
