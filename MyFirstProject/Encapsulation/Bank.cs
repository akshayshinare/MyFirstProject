using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{
    class Bank
    {
        int acc_no;
        string ac_name;
        double balanse;

        public int Ac_number
        {
            get
            {
                return acc_no;
            }
            set
            {
                acc_no = value;
            }
        }

        public string Ac_Name
        {
            get
            {
                return ac_name;
            }
            set
            {
                ac_name = value;
            }
        }
        public double Ac_Bal
        {
            get
            {
                return balanse;
            }
            set
            {
                balanse = value;
            }
        }
    }

    class AccountInfo
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Ac_number = 025846785;
            b.Ac_Name = "Akshay Shinare";
            b.Ac_Bal = 1025.50;

            Console.WriteLine("Account Number=  " + b.Ac_number + "  Account Name= " + b.Ac_Name + "  Account Balance= " + b.Ac_Bal);
        }
    }
}
