using System;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Minefield.Movers;

namespace TurtleChallenge.Core.Turtle
{
    public static class MoveResultExtensions
    {
        public static TurtleStatus MapToTurtleStatus(this MoveResult result)
        {
            switch (result)
            {
                case MoveResult.MineHit:
                    return TurtleStatus.MineHit;

                case MoveResult.Success:
                    return TurtleStatus.Success;

                case MoveResult.StillInDanger:
                case MoveResult.CannotMove:
                    return TurtleStatus.StillInDanger;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}