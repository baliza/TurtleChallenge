using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Core.Minefield.Movers
{
    public abstract class Mover : IMover
    {
        protected MoveResult StepIn(Point nextPosition, Tile[,] tiles)
        {
            var nextTile = tiles[nextPosition.X, nextPosition.Y];
            return nextTile.StepIn();
        }

        public abstract bool CanHandle(CompassDirection direction);

        public abstract MoveResult Move(IMindFieldManager mf);
    }
}