using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Private
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.firstName = "Alice";
            customer1.lastName = "Alice";
            customer1.gender = "women";
            customer1.salary = 1000;

            // Age is a private field, it can be accesible only in class which is cretaed  
            //customer1.age = 30; --> ERROR


            customer1.PrintCustomerInfo();

            //PrintName is a private method, it can be accesible only in class which is cretaed
            //customer1.Printname(); --> ERROR

            Console.ReadLine();
        }  
    }
    
}
