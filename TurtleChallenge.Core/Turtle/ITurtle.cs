using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Turtle
{
    public interface ITurtle
    {
        TurtleStatus CurentStatus { get; }

        CompassDirection CurentDirection { get; }

        TurtleStatus Move();

        void Rotate();
    }
}