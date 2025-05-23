using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personal P1 = new Personal();

            Console.Write("Enter a Id number : ");
            //set bloklarına girdi
            P1.id_No = Console.ReadLine();

            //get bloklarına girdi
            Console.WriteLine("Your id is: " + P1.id_No);

            Console.ReadLine();
        }
    }
}
