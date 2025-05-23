using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList br kolleksiyon türüdür.İstediğimiz type'daki değerleri tutan
            //İçerisinde yardımcı metodlar barındıran bir sınıftır

            ArrayList collection = new ArrayList();

            collection.Add("Sıla");
            collection.Add("Ilayda");

            int b = collection.Count;
            Console.WriteLine("Number of element: "+ b);

            bool isContains = collection.Contains("Sıla");
            
            collection.Remove("Sıla");

            collection.IndexOf("Ilayda");

            collection.Insert(1, "Fatma");

            collection.Clear();

            collection.Reverse();

            collection.Sort();

            foreach (var a in collection)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

            
        }
    }
}
