using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        { // property of customer1
            Customer customer1 = new Customer();
            customer1.firstName = "Brian";
            customer1.lastName = "Lina";
            customer1.job = "Engineer";
            customer1.Id = 1;
            customer1.age = 27;
            customer1.salary = 7000;

            // property of customer2
            Customer customer2 = new Customer();
            customer2.firstName = "Donald";
            customer2.lastName = "Black";
            customer2.job = "Officer";
            customer2.Id = 2;
            customer2.age = 49;
            customer1.salary = 6000;

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer1);
            customermanager.Add(customer2);
            customermanager.List(customer1);
            customermanager.Delete(customer1);





        }
    }
}
