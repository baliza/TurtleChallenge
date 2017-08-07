using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle.Rotators
{
    public interface IRotator
    {
        bool CanHandle(CompassDirection direction);

        CompassDirection Rotate();
    }
}