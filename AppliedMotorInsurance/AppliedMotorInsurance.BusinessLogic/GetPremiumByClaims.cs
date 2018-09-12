using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.BusinessLogic
{
    public static class GetPremiumByClaims
    {
        public static double GetPremium_claims(double premium, int newClaims, int oldClaims)
        {
            
            double premiumNewClaims = 0.00;
            double premiumOldClaims = 0.00;

            if (newClaims > 0)
               {
                premiumNewClaims = (premium * .20) * newClaims;
               }
            if (oldClaims > 0)
                {
                premiumOldClaims = (premium * .10) * oldClaims;
                }

            return (premium + premiumNewClaims + premiumOldClaims);
        }
    }
}
