using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_ProDiet.DAL.Helpers
{
    public static class Helpers
    {
        private static string _connectionString = @"Server=.\SQLEXPRESS;Database=ProDietAppDB;Trusted_Connection=True;Trust Server Certificate=True";
       public static string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
