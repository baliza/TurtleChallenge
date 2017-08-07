using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Minefield.Movers
{
    public class WestMover : Mover
    {
        public override bool CanHandle(CompassDirection direction)
        {
            return direction == CompassDirection.West;
        }

        public override MoveResult Move(IMindFieldManager mf)
        {
            var nextPosition = new Point(mf.TurtlesCurrentPosition.X, mf.TurtlesCurrentPosition.Y - 1);
            if (nextPosition.Y < 0)
                return MoveResult.CannotMove;
            return StepIn(nextPosition, mf.Tiles);
        }
    }
}