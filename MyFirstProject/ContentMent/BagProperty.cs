using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class BagProperty
    {
        string b_brand;
        int b_price;
        string b_color;
        Pen p;

        public string Brand_name
        {
            get { return b_brand; }
            set { b_brand = value; }
        }
        public int Bag_pri
        {
            get { return b_price; }
            set { b_price = value; }
        }
        public string Bag_color
        {
            get { return b_color; }
            set { b_color = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }

    }

    class Pen
    {
        int pen_length;
        string pen_name;
        string pen_color;
        string pen_type;

        public int P_length
        {
            get { return pen_length; }
            set { pen_length = value; }
        }
        public string Pen_name
        {
            get { return pen_name; }
            set { pen_name = value; }
        }
        public string Pen_color
        {
            get { return pen_color; }
            set { pen_color = value; }
        }
        public string Pen_type
        {
            get { return pen_type; }
            set { pen_type = value; }
        }
           
    }
    class BagInfo
    {

        static void Main(string[] args)
        {
            BagProperty b = new BagProperty();
            b.Brand_name = "Addidas";
            b.Bag_pri = 3000;
            b.Bag_color = "Black";

            b.P = new Pen();
            b.P.P_length = 15;
            b.P.Pen_name = "Cello";
            b.P.Pen_color = "Blue";
            b.P.Pen_type = "Point Pen";

            Console.WriteLine(b.Brand_name + " " + b.Bag_pri + " " + b.Bag_color);
            Console.WriteLine(b.P.P_length + " " + b.P.Pen_name + " " + b.P.Pen_color + " " + b.P.Pen_type);
        }
    }
}
