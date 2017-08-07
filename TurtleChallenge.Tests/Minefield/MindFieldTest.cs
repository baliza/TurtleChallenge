using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Tests.Minefield
{
    [TestClass]
    public class MindFieldTest
    {
        private Point _exit;
        private IList<Point> _mineList;
        private Size _size;

        [TestMethod]
        public void Moves_OK_Into_Exit()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(4, 3);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.North);
            Assert.AreEqual(result, MoveResult.Success);
        }

        [TestMethod]
        public void Moves_OK_Into_Mine()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 2);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.South);
            Assert.AreEqual(result, MoveResult.MineHit);
        }

        [TestMethod]
        public void Moves_ok_South()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 0);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.South);
            Assert.AreEqual(result, MoveResult.StillInDanger);
        }

        [TestMethod]
        public void Moves_ok_East()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 0);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.East);
            Assert.AreEqual(result, MoveResult.StillInDanger);
        }

        [TestMethod]
        public void Moves_ok_North()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(1, 0);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.North);
            Assert.AreEqual(result, MoveResult.StillInDanger);
        }

        [TestMethod]
        public void Moves_ok_West()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 1);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.West);
            Assert.AreEqual(result, MoveResult.StillInDanger);
        }

        [TestMethod]
        public void Does_Not_Move_OutBounds_North()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 0);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.North);
            Assert.AreEqual(result, MoveResult.CannotMove);
        }

        [TestMethod]
        public void Does_Not_Move_OutBounds_west()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(0, 0);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.North);
            Assert.AreEqual(result, MoveResult.CannotMove);
        }

        [TestMethod]
        public void Does_Not_Move_OutBounds_South()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(itg.SquareDimensions.Large - 1, itg.SquareDimensions.Height - 1);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.South);
            Assert.AreEqual(result, MoveResult.CannotMove);
        }

        [TestMethod]
        public void Does_Not_Move_OutBounds_East()
        {
            var itg = GetTileGenerator();
            var startingPoint = new Point(itg.SquareDimensions.Large - 1, itg.SquareDimensions.Height - 1);
            var mf = GetMindField(itg, startingPoint);
            var result = mf.Move(CompassDirection.East);
            Assert.AreEqual(result, MoveResult.CannotMove);
        }

        private static MindField GetMindField(ITileGenerator itg, Point startingPoint)
        {
            var mf = new MindField(itg);
            mf.SetStartPosition(startingPoint);
            return mf;
        }

        public ITileGenerator GetTileGenerator()
        {
            _size = new Size(10, 4);
            _mineList = new List<Point>
            {
                new Point(1, 2),
                new Point(2, 2)
            };
            _exit = new Point(3, 3);
            return new TileGenerator(_size, _mineList, _exit);
        }
    }
}