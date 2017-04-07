using System;

namespace BowlingGameTests
{
    internal class Game
    {
        public Frame currentFrame;

        private Frame[] frameArray;
        private static int frameIndex = 0;

        public Game()
        {
            currentFrame = new Frame();
            frameArray = new Frame[10];
        }

        public void Roll(int v)
        {
            if (currentFrame.Roll1 == null)
            {
                currentFrame.Roll1 = v;

                if(currentFrame.Roll1 == 10)
                {
                    currentFrame.IsStrike = true;
                    SetFrameScore();
                }
            }
            else
            {
                currentFrame.Roll2 = v;

                if((currentFrame.Roll1 ?? 0) + currentFrame.Roll2 == 10)
                {
                    currentFrame.isSpare = true;

                   
                }

                SetFrameScore();
            }
        }

        private void SetFrameScore()
        {
            currentFrame.Score = (currentFrame.Roll1 ?? 0) + currentFrame.Roll2;
            frameArray[frameIndex++] = currentFrame;
            currentFrame = new Frame();
        }

        public Frame GetPreviousFrame()
        {
            if (frameIndex == 0)
                return null;

            return frameArray[frameIndex - 2];
        }

        public Frame GetLatestFrame()
        {
            return frameArray[frameIndex - 1];
        }


    }
}