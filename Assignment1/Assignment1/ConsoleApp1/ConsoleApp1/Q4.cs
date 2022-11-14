using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.WriteLine("enter the number for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number for b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before swapping a={0} and b={1}", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("after swapping a={0} and b={1}", a, b);
            Console.ReadLine();


        }
    }
}
    

