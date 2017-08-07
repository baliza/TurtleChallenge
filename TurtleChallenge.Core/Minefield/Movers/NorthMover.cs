using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Minefield.Movers
{
    public class NorthMover : Mover
    {
        public override bool CanHandle(CompassDirection direction)
        {
            return direction == CompassDirection.North;
        }

        public override MoveResult Move(IMindFieldManager mf)
        {
            var nextPosition = new Point(mf.TurtlesCurrentPosition.X - 1, mf.TurtlesCurrentPosition.Y);
            if (nextPosition.X < 0)
                return MoveResult.CannotMove;
            return StepIn(nextPosition, mf.Tiles);
        }
    }
}