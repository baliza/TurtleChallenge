using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Minefield.Movers
{
    public class EastMover : Mover
    {
        public override bool CanHandle(CompassDirection direction) {
            return direction == CompassDirection.East;
        }
        public override MoveResult Move(IMindFieldManager mf)
        {
            var nextPosition = new Point(mf.TurtlesCurrentPosition.X, mf.TurtlesCurrentPosition.Y + 1);
            if (nextPosition.Y >= mf.SquareDimensions.Height)
                return MoveResult.CannotMove;
            return StepIn(nextPosition, mf.Tiles);
        }
    }
}