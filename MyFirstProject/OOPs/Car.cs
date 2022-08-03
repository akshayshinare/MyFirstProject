using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
    class Car
    {

        public string car_name;
        public int car_price;
        public string car_color="Black";
        public int car_model_number;
        static void Main(string[] args)
        {
            Car Audi = new Car();
            Audi.car_name = "Audi";
            Audi.car_price = 7543354;
            Audi.car_model_number = 989646;

            Console.WriteLine(Audi.car_name + " " + Audi.car_price + " " + Audi.car_color + " " + Audi.car_model_number);
        }
    }
}
