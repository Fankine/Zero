using Gameplay.Gambits.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplay.Gambits
{
    public class Gambit
    {
        public IEnumerable<Condition> Conditions { get; set; }
        public IAction Action { get; set; }
    }
}
