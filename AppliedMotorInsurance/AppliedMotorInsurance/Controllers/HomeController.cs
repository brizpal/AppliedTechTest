using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppliedMotorInsurance.BusinessLogic;
using AppliedMotorInsurance.Common;
using AppliedMotorInsurance.ViewModels;

namespace AppliedMotorInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult CalulatePremium(PolicyViewModel policydata)
        {

            double premium = 500.00;
            double newPremium = 0.00;

            DateTime dob = Convert.ToDateTime(policydata.driver.DateOfBirth);
            int age = GetAge.calculate_age(dob);


            if (CheckDecline_Claims.chkDecline_claims(3) > 3)
            {
                Console.WriteLine("Policy has more than 3 claims");
            }

            Console.WriteLine(CheckDecline_Age.chkDecline_age(age, policydata.driver.DriverName));



            newPremium = newPremium + GetPremiumByOccupation.GetPremium_occupation(premium,policydata.driver.DriverOccupation);
            newPremium = newPremium + GetPremiumByClaims.GetPremium_claims(premium, 4, 1);
            newPremium = newPremium + GetPremiumByAge.GetPremium_age(premium, 40);


            return PartialView(policydata);

        }


    }
}