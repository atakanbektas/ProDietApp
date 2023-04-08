using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WFA_ProDiet.MODELS.Enums;
using WFA_ProDiet.MODELS.Models;

namespace WFA_ProDiet.BLL
{
    public static class FuncCustomer
    {
       
        
        public static List<Customer> GetCustomers()
        {
            return ProDietDb._context.Customers.ToList();
        }
        public static bool AddCustomer(Customer user)
        {
            if (user != null)
            {
                ProDietDb._context.Customers.Add(user);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
         public static bool AddRangeCustomer(List<Customer> users)
        {
            if (users != null)
            {
                ProDietDb._context.Customers.AddRange(users);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateCustomer(Customer user)
        {
            if (user != null)
            {
                ProDietDb._context.Customers.Attach(user);
                 ProDietDb._context.Entry(user).State=EntityState.Modified;
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool RemoveCustomer(Customer user)
        {
            if (user != null)
            {
                ProDietDb._context.Customers.Remove(user);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;

        }
          public static bool RemoveRangeCustomer(ICollection<Customer> users)
        {
            if (users != null)
            {
                ProDietDb._context.Customers.RemoveRange(users);
                ProDietDb._context.SaveChanges();
                return true;
            }
            return false;

        }

        public static Customer GetCustomerByID(int userID)
        {
            return ProDietDb._context.Customers.Find(userID);
        }
        
        public static List<Customer> SearchCustomer(Func<Customer, bool> predicate)
        {
            List<Customer> findedUsers = new List<Customer>();
            
            foreach (Customer user in ProDietDb._context.Customers)
            {
                if (predicate(user))
                {
                    findedUsers.Add(user);
                }
            }

            return findedUsers;
        }

       

      
    }
}
