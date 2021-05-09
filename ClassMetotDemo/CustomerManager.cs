using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("First name: "+customer.firstName + " " + " Last name: "+customer.lastName + " " + "Customer's age:  "+customer.age + " " +"Customer's job: "+ customer.job + " " +" Customer's Id: "+ customer.Id + " " +"Customer's salary: "+ customer.salary+" (customer information added)");

        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.firstName);
            Console.WriteLine(customer.lastName);
            Console.WriteLine(customer.age);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.job);
            Console.WriteLine(customer.salary);
            Console.WriteLine(" successfuly listed");


        }
        public void Delete(Customer customer)
        {
            
            Console.WriteLine(customer.firstName=" not found ");
            Console.WriteLine(customer.lastName = " not found ");
            Console.WriteLine(customer.age=0);
            Console.WriteLine(customer.Id = 0);
            Console.WriteLine(customer.job = " not found ");
            Console.WriteLine(customer.salary = 0);
            Console.WriteLine("customer information has been deleted");


        }
    }
}
