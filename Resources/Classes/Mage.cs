﻿using System.Collections.Generic;
using Gameplay.Contracts.Actions;
using Gameplay.GameElements.Units;

namespace Resources.Classes
{
    public class Mage : IHeroClass
    {
        public string Name { get; }
        public int Tiers { get; }
        public IHeroClass Prerequisite { get; }
        public IEnumerable<IHeroClass> Evolutions { get; }
        public IEnumerable<IAction> Actions { get; }

        public Mage()
        {
            Name = "Mage";
            Tiers = 1;
            Prerequisite = null;
            Evolutions = new List<IHeroClass>();
            Actions = new List<IAction>();
        }
    }
}
