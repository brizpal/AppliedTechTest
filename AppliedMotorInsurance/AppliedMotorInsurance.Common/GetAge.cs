using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.Common
{
    public static class GetAge
    {

        public static int calculate_age(DateTime dateOfBirth)
        {
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                return ((DateTime.Now.Year - dateOfBirth.Year) - 1);
            }
            else
            {
                return (DateTime.Now.Year - dateOfBirth.Year);
            }
            
        }

    }
}
