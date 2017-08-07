using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle.Rotators
{
    public class WestToNorthRotator : IRotator
    {
        public bool CanHandle(CompassDirection direction)
        {
            return CompassDirection.West == direction;
        }

        public CompassDirection Rotate()
        {
            return CompassDirection.North;
        }
    }
}