using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using usefull_functions;

namespace _011b_intervaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pozadovanou delku pole, dm, hm, pocet intervalu:");
            int n = int.Parse(Console.ReadLine());
            int dm = int.Parse(Console.ReadLine());
            int hm = int.Parse(Console.ReadLine());
            int pi = int.Parse(Console.ReadLine());

            int[] array = Functions.random_array(n, dm, hm);

            int[] intervals = new int[pi+1];
            intervals[0] = dm;
            int[] count = new int[pi];
            
            double mez = ((hm + 1) - dm) / pi;


            for(int i = 1; i < intervals.Length; i++)
            {
                intervals[i] = (int)(i * mez);
            }
            
            Console.WriteLine();
            Functions.array_out(array);
            Console.WriteLine();

            int a = 0, b = 0;
            Array.Sort(array);
            while (a < array.Length && b < intervals.Length - 1)
            {
                if (array[a] <= intervals[b + 1])
                {
                    count[b]++;
                    a++;
                }
                else
                {
                    b++;
                }
            }
            while (a < array.Length)
            {
                count[intervals.Length - 2]++;
                a++;
            }

            for (int i = 0; i < intervals.Length-1; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("v intervalu <{0}-{1}>: {2}", intervals[i], intervals[i+1], count[i]);
                }
                else
                {
                    Console.WriteLine("v intervalu <{0}-{1}>: {2}", intervals[i]+1, intervals[i + 1], count[i]);
                }
                   
            }

            Console.WriteLine("\n" + Functions.array_sum(count));

        }
    }
}
