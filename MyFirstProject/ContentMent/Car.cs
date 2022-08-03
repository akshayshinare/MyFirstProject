using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class Engine
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    class Car
    {
        int model_no;
        string cname;
        int price;
        Engine en;
        
        public int Model_no
        {
            get { return model_no; }
            set { model_no = value; }
        }
        public string CName
        {
            get { return cname; }
            set { cname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine En
        {
            get { return en; }
            set { en = value; }
        }

    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_no = 50014;
            c.CName = "Audi";
            c.Price = 8000000;
            c.En = new Engine();
            c.En.Type = "Petrol";

            Console.WriteLine(c.Model_no + " " + c.CName + " " + c.Price + " "+c.En.Type);
        }
    }
}
