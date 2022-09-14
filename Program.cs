using System;

namespace Operator_Exercise
{
    internal class Program
    {
        public static double AreaOfCircle(double num1)
        {
          return  3.14 *  (num1 * num1);
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine(remainder);
                Console.WriteLine(quotient);
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

            }
            Console.WriteLine("what is the radius of your circle");
            var radius = Console.ReadLine();
            Console.WriteLine(AreaOfCircle(Convert.ToDouble(radius)));
            //17 / 4 is 4 remainder 1
            Console.ReadLine();
        }
    }
}
