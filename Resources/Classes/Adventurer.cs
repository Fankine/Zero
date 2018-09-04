using System.Collections.Generic;
using Gameplay.Contracts.Actions;
using Gameplay.GameElements.Units;

namespace Resources.Classes
{
    public class Adventurer : IHeroClass
    {
        public string Name { get; }
        public int Tiers { get; }
        public IHeroClass Prerequisite { get; }
        public IEnumerable<IHeroClass> Evolutions { get; }
        public IEnumerable<IAction> Actions { get; }

        public Adventurer()
        {
            Name = "Adventurer";
            Tiers = 0;
            Prerequisite = null;
            Evolutions = new List<IHeroClass> { new Warrior(), new Rogue(), new Mage() };
            Actions = new List<IAction>();
        }
    }
}
