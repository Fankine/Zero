using System.Collections.Generic;
using Gameplay.Contracts.Actions;
using Gameplay.Enums;
using Gameplay.GameElements.Units;

namespace Resources.Actions
{
    public class Attack : IAction
    {
        public string Name { get; }
        public int Power { get; }
        public int ScreenShakePower { get; set; }
        public ActionTime ActionTime { get; }
        public Target Target { get; }
        public IEnumerable<IHeroClass> ClassRestrictions { get; }

        public Attack()
        {
            Name = "Attack";
            Power = 10;
            ScreenShakePower = 0;
            ActionTime = new ActionTime(10, 10, 10);
            Target = Target.Forward;
            ClassRestrictions = new List<IHeroClass>();
        }
    }
}
