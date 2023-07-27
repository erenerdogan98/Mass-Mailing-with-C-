using MassMailling_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassMailling_Core.Interface
{
    public interface InterfaceCustomerRepository 
    {
        int AddRegistration(Customer c);
        int UpdateRegistration(Customer c);
        string GenerateCoupon();
        Customer FindCoupon(string CouponCode);
        List<Customer> AllList();
        Customer BringID(int ID);

        // we will implement these methods and we should use all.
    }
}
