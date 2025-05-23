using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    // Bir class sadece bir class'ı miras alabilir
    // cat sınıfı animal sınıfını iki nokta üst üste koyarak, miras almak istiyorum demiş oldu
    public class Cat : Animal 
    {
        public string catEyeColor;
        public void meow()
        {
            Console.WriteLine("cat is meowing.");
        }
    }
}
