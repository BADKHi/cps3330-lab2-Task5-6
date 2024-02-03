using System;

using lab2Task5Library;

    namespace TestMyRoot
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, num3, max, val;

            Console.WriteLine("Do you want to find the MAXIMUM value between 2 or 3 numbers? ");
        while (true)
            {
                val = Convert.ToDouble(Console.ReadLine());

                if (val == 2)
                {
                    Console.WriteLine("Lets find the MAXIMUM value between two numbers!");
                    Console.Write("Enter your first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    max = lab2Task5Library.Class1.Max2Num(num1, num2);
                }
                else if (val == 3)
                {
                    Console.WriteLine("Lets find the MAXIMUM value between three numbers!");
                    Console.Write("Enter your first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your third number: ");
                    num3 = Convert.ToDouble(Console.ReadLine());

                    max = lab2Task5Library.Class1.Max3Num(num1, num2, num3);
                }
                else
                    Console.Write("Please enter the number 2 or 3: ");

            }
            //Mekhi Wood-Brock
            //CPS3330
            //Section *01
            //Lab #2


        }

    }
}

