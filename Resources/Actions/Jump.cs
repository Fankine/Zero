using System.Collections.Generic;
using Gameplay.Contracts.Actions;
using Gameplay.Enums;
using Gameplay.GameElements.Units;

namespace Resources.Actions
{
    public class Jump : IAction
    {
        public string Name { get; }
        public int Power { get; }
        public int ScreenShakePower { get; set; }
        public ActionTime ActionTime { get; }
        public Target Target { get; }
        public IEnumerable<IHeroClass> ClassRestrictions { get; }

        public Jump()
        {
            Name = "Jump";
            Power = 1;
            ScreenShakePower = 0;
            ActionTime = new ActionTime(10,10,10);
            Target = Target.Upward;
            ClassRestrictions = new List<IHeroClass>();
        }
    }
}
