using Gameplay.GameElements;

namespace Gameplay.Contracts.Actions
{
    public interface IRangedAction : IAction
    {
        Projectile Projectile { get; }
    }
}
