using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle.Rotators
{
    public class NorthToEastRotator : IRotator
    {
        public bool CanHandle(CompassDirection direction)
        {
            return CompassDirection.North == direction;
        }

        public CompassDirection Rotate()
        {
            return CompassDirection.East;
        }
    }
}