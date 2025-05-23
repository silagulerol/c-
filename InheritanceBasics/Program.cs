using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "oreo";
            cat.color = "white/black";
            cat.gender = "women";
            cat.catEyeColor = "black";

            //cat.age = 5; --> ERROR

            cat.animalInfoShow();

            cat.meow();

            Console.ReadLine();
        }
    }
}
