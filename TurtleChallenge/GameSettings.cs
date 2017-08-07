using System.Collections.Generic;
using TurtleChallenge.Core.Common;

namespace TurtleChallenge
{
    public class GameSettings
    {
        public Point Exit { get; set; }
        public IList<Point> Mines { get; set; }
        public Size Size { get; set; }
        public Point Start { get; set; }
        public CompassDirection StartingDirection { get; set; }
    }
}