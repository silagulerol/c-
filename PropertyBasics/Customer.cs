using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyBasics
{
    public class Customer
    {
        /*
        public int weight; // Variable-Field

        // Property'nin açılmamış yapısı
        // getter ve setter blokları açılmadığı zaman property'ler aynı field gibi davranırlar
        
        public int weight2 { get; set; } // Property
        
         */



        private int weight;// weight adında bir variable tanımladık
        
        // weight'e erişemediğimiz için buna bir property tanımladık
        // Property'nin açılmış yapısı -> Kapsülleme yapacağız 
        public int WEIGHT //int değerler alan bir WEIGHT adında bir property tanımladık
        {
            get
            {
                return weight;
            }
            
            set
            {
                if (value < 0)
                {
                    weight = 0;
                }
                else
                {
                    weight = value;
                }
            }

        }
    }
}
