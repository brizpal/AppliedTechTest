using System;
using System.Collections.Generic;
using System.Text;

namespace AppliedMotorInsurance.BusinessLogic
{
    public static class CheckDecline_PolicyStartDate
    {

        public static string chkDecline_policystartdate(DateTime policystartdate)
        {
                if (DateTime.Compare(policystartdate, DateTime.Now) < 0)
                {
                    return String.Format("Policy Declined : start date of policy earlier than {0}", DateTime.Today);
                }
            else
            {
                return ("Start Date matches policy requirements");
            }

        }

    }
}
