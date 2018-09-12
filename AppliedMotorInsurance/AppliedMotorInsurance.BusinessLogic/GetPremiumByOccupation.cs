using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.BusinessLogic
{
    public static class GetPremiumByOccupation
    {
        public static double GetPremium_occupation(double premium, string occupation)
        {
            switch (occupation)
            {
                case "Chauffeur":
                    return premium + (premium * .10);

                case "Accountant":
                    return premium - (premium * .10);

                default:
                    return premium;

            }
            
        }
    }
}
