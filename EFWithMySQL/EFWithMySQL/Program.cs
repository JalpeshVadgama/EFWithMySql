using System;

namespace EFWithMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {FirstName = "Jalpesh", 
                                              LastName = "Vadgama",
                                              City = "Ahmedabad"};


            using (CustomerDataConext customerDataConext = new CustomerDataConext())
            {
                customerDataConext.Customers.Add(customer);
                customerDataConext.SaveChanges();
                Console.WriteLine("Customer Added Sucesscully");

                //Code to fetch data from MySQL
                foreach (var anotherCustomer in customerDataConext.Customers)
                {
                    Console.WriteLine("Customer Details");
                    Console.WriteLine(anotherCustomer.FirstName);
                    Console.WriteLine(anotherCustomer.LastName);
                    Console.WriteLine(anotherCustomer.City);
                }
            }

        }
    }
}
