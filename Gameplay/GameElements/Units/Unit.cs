using System.Collections.Generic;
using Gameplay.Enums;
using Gameplay.Gambits;
using Gameplay.Gambits.Actions;

namespace Gameplay.GameElements.Units
{
    public class Unit
    {
        public Stats Stats { get; set; }
        public IEnumerable<Gambit> Gambits { get; set; }
        public IEnumerable<StatusEffect> StatusEffects { get; set; }
        public IAction CurrentAction { get; set; }
        public bool IsBusy { get; set; }
        private int _busyTime;

        public Unit(Stats stats)
        {
            Stats = stats;
        }

        public void Act()
        {
        }
    }
}
