using System;
            namespace smily_ConsoleApp2
    {
        internal class Q1
        {
            static void Main(string[] args)

            {
                Console.WriteLine("please enter two numbers to add substract multiply and divide");
                int number1, number2 = 0;
                int add, substract, multiply, divide = 0;
                Console.WriteLine("please enter firstnumber");

                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter second number");
                number2 = Convert.ToInt32(Console.ReadLine());


                add = number1 + number2;
                substract = number1 - number2;
                multiply = number1 * number2;
                divide = number1 / number2;

                Console.WriteLine("results");
                Console.WriteLine("addition {0}", add);
                Console.WriteLine("substraction {0}", substract);
                Console.WriteLine("multi[plication {0}", multiply);
                Console.WriteLine("division {0}", divide);
                Console.ReadLine();



            }
        }
    }



    

