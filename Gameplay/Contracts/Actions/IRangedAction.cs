using Gameplay.GameElements;

namespace Gameplay.Gambits.Actions
{
    public interface IRangedAction : IAction
    {
        Projectile Projectile { get; }
    }
}
