using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppliedMotorInsurance.Models;

namespace AppliedMotorInsurance.ViewModels
{
    public class PolicyViewModel
    {
        public Driver driver { get; set; }

        public Claim  claim { get; set; }

        public Policy policy { get; set; }
    }
}