using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
    class Vehicle
    {
        public int model_no;
        public string type_vehicle;
        public int wheels;
        public double avrage;

        public void AcceptDetails(int mno,string tv,int wh)
        {
            model_no = mno;
            type_vehicle = tv;
            wheels = wh;
        }

        public void AcceptAvarage()
        {
            
            if(wheels==4)
            {
                avrage = 20;
            }
            else if(wheels==2)
            {
                avrage = 50;
            }
            else if(wheels==8)
            {
                avrage = 10;
            }
        }

        public void Display()
        {
            Console.WriteLine(model_no+" "+type_vehicle+" "+wheels+" "+avrage);
        }

        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Console.WriteLine("enter Car model number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter car type");
            string typev =(Console.ReadLine());
            Console.WriteLine("enter no of wheel car");
            int vwheel = int.Parse(Console.ReadLine());

            v.AcceptDetails(num,typev,vwheel);
            v.AcceptAvarage();
            v.Display();
        }

    }
}
