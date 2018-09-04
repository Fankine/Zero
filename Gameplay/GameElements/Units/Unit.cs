using System.Collections.Generic;
using System.Linq;
using Gameplay.Contracts;
using Gameplay.Contracts.Actions;
using Gameplay.Enums;
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
        public bool IsBusy => _busyTime > 0;
        private int _busyTime;

        public Unit(Stats stats)
        {
            Stats = stats;
        }

        public IAction Act(GameEnvironment environment)
        {
            IAction result = null;

            if (!IsBusy)
                _busyTime--;
            else
            {
                foreach (var pact in CurrentlyUsedContract.Pacts)
                {
                    if (!pact.Conditions.Any(i => i.Check(environment)))
                        continue;

                    result = pact.Action;
                    _busyTime = pact.Action.ActionTime.TotalBusyTime;
                    break;
                }
            }
            return result;
        }
    }
}
