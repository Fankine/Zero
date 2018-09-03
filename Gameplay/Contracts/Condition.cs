using System;
using Gameplay.GameElements;

namespace Gameplay.Contracts
{
    public class Condition
    {
        public Func<Environnement, bool> Check { get; set; }
    }
}
