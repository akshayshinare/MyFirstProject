using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{
    class Car
    {

        int mo_no;
        string car_name;
        int price;
        int speed;

        public int Mo_number
        {
            get
            {
                return mo_no;
            }
            set
            {
                mo_no = value;
            }
        }

        public string Car_Name
        {
            get
            {
                return car_name;
            }
            set
            {
                car_name = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }
        class CarInfo
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                c.Mo_number = 10002;
                c.Car_Name = "Swift";
                c.Price = 900000;
                c.Speed = 110;

                Console.WriteLine("model no=" + c.Mo_number + "Car Name =" + c.Car_Name + "Price=" + c.Price + "Speed=" + c.Speed);

            }
        }
    }

