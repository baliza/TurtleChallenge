using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Core.Minefield
{
    public interface IMindFieldManager
    {
        Point TurtlesCurrentPosition { get; set; }
        Tile[,] Tiles { get; set; }
        Size SquareDimensions { get; }
    }
}