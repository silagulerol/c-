using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classBasics
{
    public class Car
    {
        //FIELDS, VARIABLES
        public int doorNumber;
        public string carModel;
        public string carColor;


        //Constructor method 
        public Car(int door_Num, string car_Model, string car_Color)
        {
            doorNumber = door_Num;
            carModel = car_Model;
            carColor = car_Color;
        }


        //METHODS
        public void startMotor()
        {
            Console.WriteLine("Motor is working...");
        }

        public void lockDoors()
        {
            Console.WriteLine("Doors are locked...");
        }
    }
}
