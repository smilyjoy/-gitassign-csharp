﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates
{
    public delegate void EmployeeDelegate();
    public class MultiCastDelegate
    {
        static void Main(string[] args)
        {




            EmployeeDelegate empdel1 = new EmployeeDelegate(kilometerTravel);
            EmployeeDelegate empdel2 = new EmployeeDelegate(Tourallowance);
            EmployeeDelegate empdel3 = new EmployeeDelegate(Telephoneallowance);
            EmployeeDelegate empdel4 = new EmployeeDelegate(details);
            EmployeeDelegate empdel5 = empdel1 + empdel2 + empdel3 + empdel4;
            empdel5();



        }
        public static void kilometerTravel()
        {
            int kt = 2;
            Console.WriteLine("Kilometertravel: {0}", kt);
        }



        public static void KilometerTravel()
        {
            int kt = 2;
            Console.WriteLine("Kilometer: {0}", kt);
        }
        public static void Tourallowance()
        {
            int kt = 4;
            int ta = (int)kt * 5;
            Console.WriteLine("Tourallowance:{0}", ta);
        }
        public static void Telephoneallowance()
        {
            int tpa = 1000;
            Console.WriteLine("Telephone Allowance:{0}", tpa);
        }
        public static void details()
        {
            int ID = 1;
            string name = "Rekha";
            int salary = 20000;
            Console.WriteLine("Marketingexecutive ID:{0}", ID);
            Console.WriteLine("MarketingExecutive Name:{0}", name);
            Console.WriteLine("MarketingExecutive salary:{0}", salary);
        }




        class BankAccount
        {
            public double AccountNumber = 12345678;
            public String Name = "Indra";
            public double bankbalance = 133333434;
            public void data()
            {
                Console.WriteLine("Accountnumber={0}\nAccountHolder={1}\nBankbalace={2}", AccountNumber, Name, bankbalance);
            }
            public void deposit(double money)
            {
                if (money > 0)
                {
                    bankbalance = bankbalance + money;
                    Console.WriteLine("Bank Balance=" + bankbalance);



                }
                else
                {
                    Console.WriteLine("enter correct value of amount");



                }
                Console.WriteLine("Bank Balance=" + bankbalance);
            }
            public void withdraw(double amount)
            {
                if (amount < bankbalance)
                {
                    bankbalance -= amount;
                }
                else if (amount > bankbalance)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                }
                Console.WriteLine("Bank Balance=" + bankbalance);





            }
            public void balance()
            {
                Console.WriteLine("bank balance=" + bankbalance);
            }





        }
        class ICICIBankAccount : BankAccount
        {
            public new void withdraw(double amount)
            {
                if (amount < bankbalance)
                {
                    bankbalance -= amount;
                }
                Console.ReadLine();






            }
        }
    }
}
    
    

