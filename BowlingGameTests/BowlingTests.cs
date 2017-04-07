using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTests
{
    [TestClass]
    public class BowlingTests
    {
        [TestMethod]
        public void SimpleThrowTest()
        {
            Game game = new Game();
            game.Roll(1);

            //Assert.IsTrue(game.currentFrame.Score == 1);
            Assert.IsTrue(game.currentFrame.Roll1 == 1);
        }

        [TestMethod]
        public void SimpleTwoThrowTest()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(3);

            Assert.IsTrue(game.GetLatestFrame().Score == 4);
        }
        [TestMethod]
        public void SpareThrowTest()
        {
            Game game = new Game();
            game.Roll(1);
            game.Roll(9);

            Assert.IsTrue(game.GetLatestFrame().Score == 10);
            Assert.IsTrue(game.GetLatestFrame().isSpare);
        }

        [TestMethod]
        public void StrikeThrowTest()
        {
            Game game = new Game();
            game.Roll(10);

            Assert.IsTrue(game.GetLatestFrame().Score == 10);
            Assert.IsTrue(game.GetLatestFrame().IsStrike);
        }

        [TestMethod]
        public void ThrowOneBallWithPreviousFrame()
        {
            Game game = new Game();

            //frame 1
            game.Roll(1);
            game.Roll(3);

            //frame 2
            game.Roll(4);
            game.Roll(5);

            Assert.IsTrue(game.GetLatestFrame().Score == 9);
            Assert.IsTrue(game.GetPreviousFrame().Score == 4);
        }
    }
}
