using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Minefield
{
    public interface IMindField
    {
        Point TurtlesCurrentPosition { get; }

        MoveResult Move(CompassDirection direction);

        void SetStartPosition(Point start);
    }
}