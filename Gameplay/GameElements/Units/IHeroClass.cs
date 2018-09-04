using System.Collections.Generic;
using Gameplay.Contracts.Actions;

namespace Gameplay.GameElements.Units
{
    public interface IHeroClass
    {
       string Name { get; }
       int Tiers { get; }
       IHeroClass Prerequisite { get; }
       IEnumerable<IHeroClass> Evolutions { get; }
       IEnumerable<IAction> Actions { get; }
    }
}
