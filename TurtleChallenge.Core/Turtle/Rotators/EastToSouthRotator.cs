using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle.Rotators
{
    public class EastToSouthRotator : IRotator
    {
        public bool CanHandle(CompassDirection direction)
        {
            return CompassDirection.East == direction;
        }

        public CompassDirection Rotate()
        {
            return CompassDirection.South;
        }
    }
}