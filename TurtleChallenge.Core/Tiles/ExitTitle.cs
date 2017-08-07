using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Tiles
{
    public class ExitTitle : Tile
    {
        public ExitTitle(int x, int y) : base(x, y)
        {
        }

        public ExitTitle(Point point) : base(point)
        {
        }

        public override MoveResult StepIn()
        {
            return MoveResult.Success;
        }
    }
}