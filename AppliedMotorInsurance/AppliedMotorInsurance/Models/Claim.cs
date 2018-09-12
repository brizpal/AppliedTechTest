using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliedMotorInsurance.Models
{
    public class Claim
    {
        public int ClaimId {get; set; }

        public DateTime ClaimDate { get; set; }

        public int DriverId { get; set; }
    }
}