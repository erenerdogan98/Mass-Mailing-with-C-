using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassMailling_Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Couponcode { get; set; }
        public bool CouponCondition { get; set; }
        public DateTime CouponActiveDay { get; set; }
    }
}
