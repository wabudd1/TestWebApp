using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Data
{
    public class Fibonacci
    {
        public static double Fib(int n)
        {
            double a = 0;
            double b = 1;

            for (int i = 0; i < n; i++)
            {
               double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(Fib(i));
                Console.ReadLine();
            }
        }
    }
}
