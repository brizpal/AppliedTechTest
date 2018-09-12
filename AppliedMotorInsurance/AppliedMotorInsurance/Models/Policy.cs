using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliedMotorInsurance.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }

        public DateTime PolicyStartDate { get; set; }

        public List<Driver> Drivers { set; get; }
    }
}