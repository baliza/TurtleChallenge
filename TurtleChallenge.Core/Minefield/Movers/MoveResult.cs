namespace TurtleChallenge.Core.Minefield.Movers
{
    public enum MoveResult
    {
        MineHit = 0,
        Success = 1,
        StillInDanger = 2,
        CannotMove = 3
    }
}