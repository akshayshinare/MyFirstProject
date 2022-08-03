using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class Addres
    {
        public int pincode;
        public string city;

        public Addres(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }

        public void showAddress()
        {
            Console.WriteLine(" " + pincode + " " + city);
        }


    }

    class Person1
    {
        int id;
        string name;
        Addres adr;

        Person1(int id,string name,Addres adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }
        void DisplayPerson()
        {
            Console.WriteLine(id + " " + name);
            adr.showAddress();
        }

        static void Main(string[] args)
        {
            Addres a = new Addres(232,"Ahmednagar");
            Person1 p;
            p = new Person1(1,"Akshay",a);
            p.DisplayPerson();
        }
    }

}
