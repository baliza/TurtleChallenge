using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;
using Tur = TurtleChallenge.Core.Turtle;

namespace TurtleChallenge.Tests.Turtle
{
    [TestClass]
    public class TurtleTest
    {
        private Mock<IMindField> _mindField;

        [TestMethod]
        public void Moves_Calls_The_Service()
        {
            SetMindField(MoveResult.MineHit);
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Move();
            _mindField.Verify(m => m.Move(It.Is<CompassDirection>(cd => cd == CompassDirection.West)), Times.Once);
        }

        [TestMethod]
        public void Moves_Returns_Response_MineHit()
        {
            SetMindField(MoveResult.MineHit);
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Move();
            Assert.AreEqual(t.CurentStatus, Tur.TurtleStatus.MineHit);
        }

        [TestMethod]
        public void Moves_Returns_Response_StillInDanger()
        {
            SetMindField(MoveResult.StillInDanger);
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Move();
            Assert.AreEqual(t.CurentStatus, Tur.TurtleStatus.StillInDanger);
        }

        [TestMethod]
        public void Moves_Returns_Response_StillInDanger_For_Cannot_move()
        {
            SetMindField(MoveResult.CannotMove);
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Move();
            Assert.AreEqual(t.CurentStatus, Tur.TurtleStatus.StillInDanger);
        }

        [TestMethod]
        public void Moves_Returns_Response_Success()
        {
            SetMindField(MoveResult.Success);
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Move();
            Assert.AreEqual(t.CurentStatus, Tur.TurtleStatus.Success);
        }

        [TestMethod]
        public void Rotate_Ok_East()
        {
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.East);
            t.Rotate();
            Assert.AreEqual(t.CurentDirection, CompassDirection.South);
        }

        [TestMethod]
        public void Rotate_Ok_North()
        {
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.North);
            t.Rotate();
            Assert.AreEqual(t.CurentDirection, CompassDirection.East);
        }

        [TestMethod]
        public void Rotate_Ok_South()
        {
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.South);
            t.Rotate();
            Assert.AreEqual(t.CurentDirection, CompassDirection.West);
        }

        [TestMethod]
        public void Rotate_Ok_West()
        {
            var t = new Tur.Turtle(_mindField.Object, CompassDirection.West);
            t.Rotate();
            Assert.AreEqual(t.CurentDirection, CompassDirection.North);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _mindField = new Moq.Mock<IMindField>();
        }

        private void SetMindField(MoveResult result)
        {
            _mindField.Setup(m => m.Move(It.IsAny<CompassDirection>())).Returns(result);
        }
    }
}