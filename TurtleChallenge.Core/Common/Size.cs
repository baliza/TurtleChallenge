namespace TurtleChallenge.Core.Common
{
    public class Size
    {
        public Size(int large, int height)
        {
            Height = height;
            Large = large;
        }

        public int Large { get; }

        public int Height { get; }
    }
}