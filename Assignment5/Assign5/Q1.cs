using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class EmployeeManagementSystem
    {
        public static void Main()
        {

            ArrayList Employee = new ArrayList();
            Employee.Add(1);
            Employee.Add("Smily");
            Employee.Add("Trainee");
            Employee.Add(20000);
            Employee.Add("Banglore");



            foreach (object i in Employee)
            {
                Console.WriteLine(i + " ");

            }
            Console.ReadLine();



        }
    }
}
        

        
    
