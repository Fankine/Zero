using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplay.Enums
{
    public enum Target
    {
        None,
        ClosestEnemy,
        AllEnemies,
        ClosestAlly,
        AllAllies,
        Self,
        Forward,
        Backward,
        Upward,
        Downward,
        FrontDiagonal,
        BackDiagonal
    }
}
