using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.BusinessLogic
{
    
    public static class CheckDecline_Age
    {

        public static string chkDecline_age(int age, string drivername)
        {

           
            if (age > 75)
            {
                return String.Format("Age of Oldest Driver {0}",drivername);
            }
            else if (age < 21)
            {
                return String.Format("Age of Youngest Driver {0}", drivername);
            }
            else
            {
                return ("Age matches policy requirements");
            }

        }

    }
}
