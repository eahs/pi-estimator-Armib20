using System;
using System.Collections.Generic;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double count = 0.0;
            double pi = 0.0;
            double[] x_vals = new double[n];
            double[] y_vals = new double[n];
            
            // TODO: Calculate Pi

            for (int i = 0; i < n; i++)
            {
                x_vals[i] = rand.NextDouble();
                y_vals[i] = rand.NextDouble();
                if ((x_vals[i] * x_vals[i]) + (y_vals[i] * y_vals[i]) <= 1)
                {
                    count += 1;
                }
            }
            
            return (4.0 * (count / n));
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}