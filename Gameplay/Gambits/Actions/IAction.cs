using Gameplay.Enums;

namespace Gameplay.Gambits.Actions
{
    public interface IAction
    {
        string Name { get; }
        int Power { get; }
        ActionTime Timer { get; }
        Target Target { get; }
    }
}
