namespace Gameplay.GameElements
{
    public class Projectile
    {
        public int Range { get; }
        public int Speed { get; }
        public int Duration { get; }
        public int Hitpoints { get; } //Pour la pénétration d'armure ( HP projo < HP armor = deflected )

        public Projectile(int range, int speed, int duration)
        {
            Range = range;
            Speed = speed;
            Duration = duration;
        }
    }
}
