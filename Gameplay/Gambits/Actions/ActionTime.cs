using System;
using System.Collections.Generic;
using System.Text;

namespace Gameplay.Gambits.Actions
{
    public class ActionTime
    {
        public int StartupTime { get; }
        public int ExecutionTime { get; }
        public int Cooldown { get; }

        public ActionTime(int startupTime, int executionTime, int cooldown)
        {
            StartupTime = startupTime;
            ExecutionTime = executionTime;
            Cooldown = cooldown;
        }
    }
}
