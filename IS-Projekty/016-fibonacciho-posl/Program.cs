using System;
using System.Diagnostics;

namespace _016_fibonacciho_posl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej počet členů: \n");
            int n = int.Parse(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            ulong[] array = get_fibonacci(n);
            sw.Stop();
            array_out(array);
            Console.WriteLine(sw);
            Console.ReadKey();
        }

        public static ulong[] get_fibonacci(int n)
        {
            ulong[] result = new ulong[n];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result;
        }

        public static void array_out(ulong[] array)
        {
            foreach (ulong i in array)
            {
                Console.Write("{0}; ", i);
            }
            Console.WriteLine();
        }
    }
}
