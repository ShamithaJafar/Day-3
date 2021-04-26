using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Vehicle
    {
        public string Brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut tuut I");

        }
        class Car: Vehicle
        {
            Car(string _model)
            {
                modelName = _model;
            }
            public string modelName { get; set; }
            static void Main()
            {
                Car mycar = new Car("Mustang");
                mycar.honk();
                Console.WriteLine(mycar.Brand + " " + mycar.modelName);
                Console.ReadLine();
               

            }
        }
    }
}
