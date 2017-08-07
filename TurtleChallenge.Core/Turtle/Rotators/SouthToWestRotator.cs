using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle.Rotators
{
    public class SouthToWestRotator : IRotator
    {
        public bool CanHandle(CompassDirection direction)
        {
            return CompassDirection.South == direction;
        }

        public CompassDirection Rotate()
        {
            return CompassDirection.West;
        }
    }
}