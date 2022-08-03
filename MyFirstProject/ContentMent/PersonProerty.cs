using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class Address
    {
        int pincode;
        string city;

        public int PinCode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }

    class Person
    {
        int id;
        string name;
        string adr;
        Address Ad;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Addr
        {
            get { return adr; }
            set { adr = value; }
        }
        public Address Add
        {
            get { return Ad; }
            set { Ad = value; }
        }
    }

    class PersonInfo
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 101;
            p.Name = "Akshay";
            p.Addr = "Ahmednagar";

            p.Add = new Address();
            p.Add.PinCode = 414305;
            p.Add.City = "Parner";

            Console.WriteLine(p.Id + " " + p.Name + " " + p.Addr + " " + p.Add.City + " " + p.Add.PinCode);
        }
    }


}
