using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveProject.HoneyManagement
{


    static class HoneyVault
    {
        private static decimal honey = Constants.Constants.INITIAL_HONEY;
        private static decimal nectar = Constants.Constants.INITIAL_NECTAR;

        internal static void Reset()
        {
            honey = Constants.Constants.INITIAL_HONEY;
            nectar = Constants.Constants.INITIAL_NECTAR;
        }

        public static bool ConsumeHoney(decimal amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            } else
            {
                return false;
            }
        }

        public static void CollectNectar(decimal amount)
        {
            if (amount > 0)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(decimal amount)
        {
            decimal nectarToConvert = amount;
            if (nectarToConvert > nectar) nectarToConvert = nectar;
            nectar -= nectarToConvert;
            honey += nectarToConvert * Constants.Constants.NECTAR_CONVERSION_RATIO;
        }

        public static string StatusReport
        {
            get
            {
                string status = $"{honey:0.00} units of honey\n" +
                                $"{nectar:0.00} units of nectar";
                string warnings = "";
                if (honey < Constants.Constants.LOW_LEVEL_WARNING) warnings +=
                                    "\nLOW HONEY - ADD A HONEY MANUFACTURER";

                if (nectar < Constants.Constants.LOW_LEVEL_WARNING) warnings +=
                                    "\nLOW NECTAR - ADD A NECTAR COLLECTOR";

                return status + warnings;
            }
        }
    }
}
