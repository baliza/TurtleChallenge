using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Tiles
{
    public interface ITile
    {
        Point Position { get; }

        MoveResult StepIn();
    }
}