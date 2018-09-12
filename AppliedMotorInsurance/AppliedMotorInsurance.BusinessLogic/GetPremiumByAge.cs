using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.BusinessLogic
{
    public static class GetPremiumByAge
    {

       public static double GetPremium_age(double premium, int age)
        {
            double premiumNewAge = 0.00;

            if (age > 21 && age < 25)
            {
                premiumNewAge = (premium * .20);
            }
            else if (age > 26 && age < 75)
            {
                premiumNewAge = (premium * .10);
            }

            return (premium + premiumNewAge);
        }
    }
}
