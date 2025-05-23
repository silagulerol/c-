using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CREATE MY OBJECT/REFERANCE FROM CAR CLASS WITH FIELDS
            Car car1 = new Car(4, "BMW","RED");


            /* 
            Car car1 = new Car();
            car1.carModel = "BMW";
            car1.carColor = "red";
            car1.doorNumber = 4;
            */



            //CALLING MY OBJECTS METHODS
            car1.startMotor();
            car1.lockDoors();

            Console.WriteLine("car color is " + car1.carColor);
            Console.WriteLine("car color is " + car1.carModel);
            Console.WriteLine("car color is " + car1.doorNumber);
            Console.ReadLine();
        }
    }
}
