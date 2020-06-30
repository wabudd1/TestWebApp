using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Fibonacci
{
    public class FibonacciSequence
    {
        public static int[] fibonacci(int limit)
        {
            int[] series = new int[1];
            Array.Resize(ref series, limit);

            series[0] = 0;
            series[1] = 1;

            for (int i = 2; i < limit; i++)
                series[i] = series[i - 1] + series[i - 2];

            return series;

        }
    }
}