using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class Engine1
    {
        public string type;

        public Engine1(string type)
        {
            this.type = type;
        }

        public void showEngine1()
        {
            Console.WriteLine(type);
        }
    }

    class Car1
    {
        int model_no;
        string car_name;
        int price;
        Engine1 En;

        Car1(int model_no, string car_name, int price, Engine1 En)
        {
            this.model_no = model_no;
            this.car_name = car_name;
            this.price = price;
            this.En = En;

        }

        void DisplayCar1()
        {
            Console.WriteLine(model_no + " " + car_name + " " + price);
            En.showEngine1();
        }

        static void Main(string[] args)
        {
            Engine1 e = new Engine1("Petrol");
            Car1 c;
            c = new Car1(1002,"Swift",900000,e);
            c.DisplayCar1();
        }
    }
}
