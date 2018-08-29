using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Constants;
using Gameplay.Gambits;
using Action = Gameplay.Gambits.Action;

namespace Gameplay
{
    public class Unit
    {
        public Stats Stats { get; set; }
        public IEnumerable<Gambit> Gambits { get; set; }
        public IEnumerable<StatusEffect> StatusEffects { get; set; }
        public bool IsOnCooldown { get; set; }
        public Action CurrentAction { get; set; }

        private int _cooldownTime;


        public void Act()
        {
        }
    }
}
