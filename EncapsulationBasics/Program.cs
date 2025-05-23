using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme temel amaç: elimizdeki değişkenlere metotlara saçma değerler atanmasını engellemek, belirli kısıtlamalar koymak
            //belirli mekanizmalarla, koymuş olduğumuz kısıtlamalara erişim sağlamak
            //How?
            //1) by using geter seter methods
            //2) by using property


            Student std1 = new Student();

            std1.setName("sıla");

            string name = std1.getName();

            if (name == "sıla")
            {
                Console.WriteLine("Succeed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.ReadLine();
        }
    }
}
