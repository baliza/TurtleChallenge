using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Tiles
{
    public abstract class Tile : ITile
    {
        protected Tile(int x, int y)
        {
            Position = new Point(x, y);
        }

        protected Tile(Point position)
        {
            Position = position;
        }

        public Point Position { get; private set; }

        public abstract MoveResult StepIn();
    }
}