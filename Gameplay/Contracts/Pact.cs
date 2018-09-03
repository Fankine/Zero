using System.Collections.Generic;
using Gameplay.Contracts.Actions;

namespace Gameplay.Contracts
{
    public class Pact
    {
        public IEnumerable<Condition> Conditions { get; set; }
        public IAction Action { get; set; }
    }
}
