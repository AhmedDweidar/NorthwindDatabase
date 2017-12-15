using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace NorthwindDatabase
{
    public class CustomerRepository
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

        public List<Customer> GetCustomer(string name)
        {
            var list = new List<Customer>();
            string query = "select CustomerID, ContactName, CompanyName, City, Country from Customers where ContactName like '%" + name + "%'";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();

                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var customer = new Customer();
                        customer.CustomerID = dr["CustomerID"].ToString();
                        customer.ContactName = dr["ContactName"].ToString();
                        customer.CompanyName = dr["CompanyName"].ToString();
                        customer.City = dr["City"].ToString();
                        customer.Country = dr["Country"].ToString();

                        list.Add(customer);
                    }
                }
            }

            return list;
        }
    }
}
