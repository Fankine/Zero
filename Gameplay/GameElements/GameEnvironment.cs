using System.Collections.Generic;
using Gameplay.GameElements.Units;

namespace Gameplay.GameElements
{
    public class GameEnvironment
    {
        public IEnumerable<Unit> Units { get; set; }
    }
}
