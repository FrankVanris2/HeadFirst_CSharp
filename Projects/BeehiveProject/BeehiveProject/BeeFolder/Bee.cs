using System;
using System.Collections.Generic;
using System.Text;
using BeehiveProject.HoneyManagement;

namespace BeehiveProject.BeeFolder
{
    abstract class Bee
    {
        public abstract decimal CostPerShift { get; }

        public string Job { get; private set; }

        public Bee(string job)
        {
            Job = job;
        }

        public virtual bool WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                return true;
            else
                return false;
        }
    }
}
