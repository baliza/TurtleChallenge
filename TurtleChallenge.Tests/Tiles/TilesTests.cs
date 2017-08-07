using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Tests.Tiles
{
    [TestClass]
    public class TilesTests
    {
        [TestMethod]
        public void MineTile_returns_MineHit()
        {
            var t = new MineTitle(0, 0);
            Assert.AreEqual(t.StepIn(), MoveResult.MineHit);
        }

        [TestMethod]
        public void ExitTitle_returns_Success()
        {
            var t = new ExitTitle(0, 0);
            Assert.AreEqual(t.StepIn(), MoveResult.Success);
        }

        [TestMethod]
        public void MineTile_returns_StepIn()
        {
            var t = new EmptyTitle(0, 0);
            Assert.AreEqual(t.StepIn(), MoveResult.StillInDanger);
        }
    }
}