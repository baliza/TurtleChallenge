using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Tests.Minefield
{
    [TestClass]
    public class TileGeneratorTest
    {
        private Point _exit;
        private IList<Point> _mineList;
        private Size _size;

        [TestMethod]
        public void Generates_Tiles_OK_Length()
        {
            //SetUp();
            var mf = new TileGenerator(_size, _mineList, _exit).GenerateTiles();
            Assert.AreEqual(mf.Length, 50);
        }

        [TestMethod]
        public void Generates_With_Exit_Ok_Put()
        {
            //SetUp();
            var mf = new TileGenerator(_size, _mineList, _exit).GenerateTiles();
            Assert.IsInstanceOfType(mf[3, 3], typeof(ExitTitle));
        }

        [TestMethod]
        public void Generates_With_Mines_Ok_Put()
        {
            //SetUp();
            var mf = new TileGenerator(_size, _mineList, _exit).GenerateTiles();
            Assert.IsInstanceOfType(mf[4, 2], typeof(MineTitle));
            Assert.IsInstanceOfType(mf[5, 2], typeof(MineTitle));
        }

        [TestInitialize]
        public void SetUp()
        {
            _size = new Size(10, 5);
            _mineList = new List<Point>
            {
                new Point(4, 2),
                new Point(5, 2)
            };
            _exit = new Point(3, 3);
        }
    }
}