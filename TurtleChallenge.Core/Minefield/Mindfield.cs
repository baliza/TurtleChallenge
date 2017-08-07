using System.Linq;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield.Movers;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Core.Minefield
{
    public class MindField : IMindField, IMindFieldManager
    {
        private readonly IMover[] _movers;
        private readonly ITileGenerator _tileGenerator;

        public MindField(ITileGenerator tileGenerator)
        {
            _tileGenerator = tileGenerator;
            _movers = new IMover[] { new NorthMover(), new SouthMover(), new EastMover(), new WestMover(), };
            TurtlesCurrentPosition = new Point(0, 0);
            Tiles = _tileGenerator.GenerateTiles();
        }

        public Size SquareDimensions { get { return _tileGenerator.SquareDimensions; } }
        public Tile[,] Tiles { get; set; }
        public Point TurtlesCurrentPosition { get; set; }

        public MoveResult Move(CompassDirection direction)
        {
            return _movers.FirstOrDefault(m => m.CanHandle(direction)).Move(this);
        }

        public void SetStartPosition(Point start)
        {
            TurtlesCurrentPosition = start;
        }
    }
}