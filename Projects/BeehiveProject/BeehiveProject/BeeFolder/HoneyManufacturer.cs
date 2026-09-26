using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveProject.BeeFolder
{
    class HoneyManufacturer : Bee
    {
        public HoneyManufacturer() : base("Honey Manufacturer") { }

        public override decimal CostPerShift
        {
            get { return Constants.Constants.HONEY_MANUFACTURER_COST; }
        }

        public override bool WorkTheNextShift()
        {
            HoneyVault.ConvertNectarToHoney(Constants.Constants.NECTAR_PROCESSED_PER_SHIFT);
            return base.WorkTheNextShift();
        }
    }
}
