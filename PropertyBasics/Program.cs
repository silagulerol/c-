using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            /*Açılamamış property kullanımı
             
            customer1.weight = 85;
            customer1.weight2 = 85;

            Console.WriteLine("Property olan weight: " + customer1.weight);
            Console.WriteLine("Variable/Field olan weight: " + customer1.weight2);
             */



            //Açılmış olan property kullanımı
            customer1.WEIGHT = 85; //Değer ataması yaptığımız için set blockları çalışır


            //Değer ataması yapmadık, get blockları çalıştı
            Console.WriteLine(customer1.WEIGHT);

        }
    }
}
