using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "ali";
            customer1.Surname = "veli";
            customer1.TcNo = "12345678910";

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNo = "98765";
            customer2.CompanyName = "veliler";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
