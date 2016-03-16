using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game
{
    public class Game
    {
        private int score;
        private int[] throws = new int[21];
        private int currentThrow;
        private int currentFrame = 1;
        private bool isFirstThrow = true;


        public int CurrentFrame
        {
            get { return currentFrame; }
        }

        public int Score()
        {
            return ScoreForFrame(CurrentFrame - 1); 
        }

        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;
            AdjustCurrentFrame();
        }

        public int ScoreForFrame(int Theframe)
        {
            int score = 0;
            int ball = 0;

            for (int currentFrame = 0;
               currentFrame < Theframe;
               currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];
                int frameScore = firstThrow + secondThrow;

                //для обработки спэа необходим бросок в следующем
                //фрейме

                if (frameScore == 10)
                {
                    score += frameScore + throws[ball];
                }
                else
                {
                    score += frameScore;
                }

                score += firstThrow + secondThrow;
            }
            return score;
        }

        private void AdjustCurrentFrame()
        {
            if (isFirstThrow)
            {
                isFirstThrow = false;
                currentFrame++;
            }
            else
            {
                isFirstThrow = true; ;
                currentFrame++;
            }
        }
    }
}
