using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Tiles
{
    public class EmptyTitle : Tile
    {
        public EmptyTitle(Point point) : base(point)
        {
        }

        public EmptyTitle(int x, int y) : base(x, y)
        {
        }

        public override MoveResult StepIn()
        {
            return MoveResult.StillInDanger;
        }
    }
}