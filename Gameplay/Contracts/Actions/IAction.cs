using Gameplay.Enums;

namespace Gameplay.Gambits.Actions
{
    public interface IAction
    {
        string Name { get; }
        int Power { get; }
        int ScreenShakePower { get; set; }
        ActionTime ActionTime { get; }
        Target Target { get; }
    }
}
