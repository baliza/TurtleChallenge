using TurtleChallenge.Core.Common;

namespace TurtleChallenge.Core.Minefield.Movers
{
    public interface IMover
    {
         bool CanHandle(CompassDirection direction);
         MoveResult Move(IMindFieldManager mf);
    }
}