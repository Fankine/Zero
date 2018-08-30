using System;
using System.Collections.Generic;
using System.Text;
using Gameplay.Gambits;

namespace Gameplay.Contracts
{
    public class Contract
    {
        public IEnumerable<Pact> Pacts { get; set; }
    }
}
