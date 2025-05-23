using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    public class Animal
    {
        public string name;
        public string gender;
        public string color;
        private int age;

        public void animalInfoShow()
        {
            Console.WriteLine("Animal name: " + name);
            Console.WriteLine("Animal gender: " + gender);
            Console.WriteLine("Animal color: " + color);
        }
    }
}
