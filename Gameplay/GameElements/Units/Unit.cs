using System.Collections.Generic;
using System.Data.Common;
using Gameplay.Contracts;
using Gameplay.Enums;
using Gameplay.Gambits;
using Gameplay.Gambits.Actions;
using Gameplay.Utilities;

namespace Gameplay.GameElements.Units
{
    public class Unit
    {
        public Stats Stats { get; set; }
        public IEnumerable<StatusEffect> StatusEffects { get; set; }

        public Location Location { get; set; }

        public Contract CurrentlyUsedContract { get; set; }
        public IEnumerable<Contract> Contracts { get; set; }

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
