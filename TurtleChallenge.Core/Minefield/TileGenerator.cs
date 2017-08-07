using System.Collections.Generic;
using System.Linq;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Core.Minefield
{
    public class TileGenerator : ITileGenerator
    {
        private readonly Point _exitPoint;
        private readonly IList<Point> _mineList;
        private readonly Size _squareDimensions;

        public TileGenerator(Size squareDimensions, IList<Point> mineList, Point exitPoint)
        {
            _mineList = mineList;
            _exitPoint = exitPoint;
            _squareDimensions = squareDimensions;
        }

        public Size SquareDimensions
        {
            get { return _squareDimensions; }
        }

        public Tile[,] GenerateTiles()
        {
            var tiles = new Tile[_squareDimensions.Large, _squareDimensions.Height];
            for (var idxX = 0; idxX < _squareDimensions.Large; idxX++)
            {
                for (var idxY = 0; idxY < _squareDimensions.Height; idxY++)
                {
                    var point = new Point(idxX, idxY);
                    if (IsExitPoint(point))
                    {
                        tiles[idxX, idxY] = new ExitTitle(point);
                        continue;
                    }
                    if (IsMine(point))
                    {
                        tiles[idxX, idxY] = new MineTitle(point);
                        continue;
                    }
                    tiles[idxX, idxY] = new EmptyTitle(point);
                }
            }
            return tiles;
        }

        private bool IsExitPoint(Point point)
        {
            return Point.AreEqual(_exitPoint, point);
        }

        private bool IsMine(Point point)
        {
            return _mineList.Any(mine => Point.AreEqual(mine, point));
        }
    }
}