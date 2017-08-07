using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Tiles;

namespace TurtleChallenge.Core.Minefield
{
    public interface ITileGenerator
    {
        Tile[,] GenerateTiles();

        Size SquareDimensions { get; }
    }
}