using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Private
{
    public class Customer
    {
        public string firstName;

        public string lastName;  

        public string gender;

        public int salary;

        private int age;


        public Customer()
        {
            age = 25;
        }


        public void PrintCustomerInfo()
        {
            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("salary: " + salary);
            Console.WriteLine("Gender: " + firstName);
            Console.WriteLine("Age: " + age);
        }

        private void PrintName()
        {
            Console.WriteLine("First name and last name: " + firstName + " " + lastName);
        }
    }
}
