using System;

namespace Gameplay.Utilities
{
    public class Location
    {
        public int X { get; }
        public int Y { get; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Location location)
        {
            var dX = X - location.X;
            var dY = Y - location.Y;
            return Math.Sqrt(dX * dX + dY * dY);
        }
    }
}
