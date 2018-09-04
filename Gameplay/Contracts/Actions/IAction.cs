using System.Collections.Generic;
using Gameplay.Enums;
using Gameplay.GameElements.Units;

namespace Gameplay.Contracts.Actions
{
    public interface IAction
    {
        string Name { get; }
        int Power { get; }
        int ScreenShakePower { get; set; }
        ActionTime ActionTime { get; }
        Target Target { get; }
        IEnumerable<IHeroClass> ClassRestrictions { get; }
    }
}
