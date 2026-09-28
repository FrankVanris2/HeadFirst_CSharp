using System;
using System.Collections.Generic;
using System.Text;
using BeehiveProject.Constants;
using BeehiveProject.HoneyManagement;

namespace BeehiveProject.BeeFolder
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("Nectar Collector") { }

        public override decimal CostPerShift
        {
            get { return Constants.Constants.NECTAR_COLLECTOR_COST; }
        }

        public override bool WorkTheNextShift()
        {
            HoneyVault.CollectNectar(Constants.Constants.NECTAR_COLLECTED_PER_SHIFT);
            return base.WorkTheNextShift();
        }
    }
}
