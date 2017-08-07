using System.Collections.Generic;
using System.Linq;
using TurtleChallenge.Core.Common;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Turtle.Rotators;

namespace TurtleChallenge.Core.Turtle
{
    public class Turtle : ITurtle
    {
        private readonly IMindField _mindField;
        private readonly List<IRotator> _rotators;

        public Turtle(IMindField mindField, CompassDirection direction)
        {
            _mindField = mindField;
            CurentDirection = direction;
            _rotators = new List<IRotator>
            {
                new NorthToEastRotator(),
                new EastToSouthRotator(),
                new SouthToWestRotator(),
                new WestToNorthRotator()
            };
            CurentStatus = TurtleStatus.StillInDanger;
        }

        public CompassDirection CurentDirection { get; set; }
        public TurtleStatus CurentStatus { get; private set; }

        public TurtleStatus Move()
        {
            var result = _mindField.Move(CurentDirection);
            CurentStatus = result.MapToTurtleStatus();
            return CurentStatus;
        }

        public void Rotate()
        {
            CurentDirection = _rotators.FirstOrDefault(r => r.CanHandle(CurentDirection)).Rotate();
        }
    }
}