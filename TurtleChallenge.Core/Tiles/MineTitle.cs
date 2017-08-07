using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Tiles
{
    public class MineTitle : Tile
    {
        public MineTitle(int x, int y) : base(x, y)
        {
        }

        public MineTitle(Point point) : base(point)
        {
        }

        public override MoveResult StepIn()
        {
            return MoveResult.MineHit;
        }
    }
}