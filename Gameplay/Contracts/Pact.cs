using Gameplay.Gambits.Actions;
using System.Collections.Generic;

namespace Gameplay.Gambits
{
    public class Pact
    {
        public IEnumerable<Condition> Conditions { get; set; }
        public IAction Action { get; set; }
    }
}
