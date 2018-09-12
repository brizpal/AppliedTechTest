using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliedMotorInsurance.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        public string DriverName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string DriverOccupation { get; set; }

        public List<Claim> Claims { set; get; }

    }
}