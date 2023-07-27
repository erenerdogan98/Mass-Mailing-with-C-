using MassMailling_Core.Database;
using MassMailling_Core.Helper;
using MassMailling_Core.Interface;
using MassMailling_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassMailling_Core.Repository
{
    public class CustomerRepository : GlobalOperations, InterfaceCustomerRepository  // we inherited and implement interface
    {
        // we will define SQL commands in class level
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValue;
        DataAccessLayer DAL; // we simply DAL in constructor method by new.

        public CustomerRepository()
        {
            DAL = new DataAccessLayer();
        }

        public int AddRegistration(Customer c)
        {
            throw new NotImplementedException();
        }

        public List<Customer> AllList()
        {
            List<Customer> customerlist = null;
            UseTryCatch(() =>
            {
                cmd = new SqlCommand("CustomerList");
                cmd.CommandType = System.Data.CommandType.StoredProcedure; // CustomerList is a proc in SQL 
                reader = DAL.BringData(cmd);
                while (reader.Read())
                {

                }
                reader.Close();
               
            });
            return customerlist;
        }

        public Customer BringID(int ID)
        {
            return null;
        }

        public Customer FindCoupon(string CouponCode)
        {
            throw new NotImplementedException();
        }

        public string GenerateCoupon()
        {
            throw new NotImplementedException();
        }

        public int UpdateRegistration(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
