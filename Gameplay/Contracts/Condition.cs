using Gameplay.GameElements;
using System;

namespace Gameplay.Gambits
{
    public class Condition
    {
        public Func<Environnement, bool> Check { get; set; }
    }
}
