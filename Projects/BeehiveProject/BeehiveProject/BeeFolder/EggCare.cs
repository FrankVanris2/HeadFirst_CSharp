using System;
using System.Collections.Generic;
using System.Text;
using BeehiveProject.HoneyManagement;

namespace BeehiveProject.BeeFolder
{
    class EggCare : Bee
    {
        private Queen queen;
        public EggCare(Queen queen) : base("Egg Care") 
        {
            this.queen = queen;
        }

        public override decimal CostPerShift
        {
            get { return Constants.Constants.EGG_CARE_COST; }
        }

        public override bool WorkTheNextShift()
        {
            queen.ReportEggConversion(Constants.Constants.CARE_PROGRESS_PER_SHIFT);
            return base.WorkTheNextShift();
        }
    }
}
