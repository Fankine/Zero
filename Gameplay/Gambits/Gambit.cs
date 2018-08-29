using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplay.Gambits
{
    public class Gambit
    {
        public IEnumerable<Condition> Conditions { get; set; }
        public Action Action { get; set; }
    }
}
