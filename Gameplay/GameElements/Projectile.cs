using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplay.GameElements
{
    public class Projectile
    {
        public int Range { get; }
        public int Speed { get; }
        public int Duration { get; }

        public Projectile(int range, int speed, int duration)
        {
            Range = range;
            Speed = speed;
            Duration = duration;
        }
    }
}
