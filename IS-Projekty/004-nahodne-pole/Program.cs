using System.Numerics;
using usefull_functions;

namespace _004_nahodne_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int odd_count = 0;
            int even_count = 0;
            int zero_count = 0;
            int neg_count = 0;
            int pos_count = 0;

            Console.WriteLine("zadej počet n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej dolní mez");
            int low = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej horní mez");
            int high = int.Parse(Console.ReadLine());



            int[] pole = Functions.random_array(n, low, high);
            int[] liche_pole = Functions.random_array_odd(n, low, high);
            int[] sude_pole = Functions.random_array_even(n, low, high);

            Console.WriteLine("prvky v polich:");
            foreach (int i in pole) { 
                Console.Write(i + " ");
                if (i == 0) { zero_count++; }
                if (i % 2 == 1) { odd_count++; }
                if (i % 2 == 0) { even_count++; }
                if (i > 0) { pos_count++; }
                if (i < 0) { neg_count++; }
            }
            Console.WriteLine("\nPočet nul: {0}  Počet sudých: {1}  Počet lichých: {2}  počet záporných: {3} počet kladných: {4}\n", zero_count, even_count, odd_count, neg_count, pos_count); Console.WriteLine("\nPočet nul: {0}  Počet sudých: {1}  Počet lichých: {2}\n", zero_count, even_count, odd_count);

            reset();

            foreach (int i in liche_pole)
            {
                Console.Write(i + " ");
                if (i == 0) { zero_count++; }
                if (i % 2 == 1) { odd_count++; }
                if (i % 2 == 0) { even_count++; }
                if (i > 0) { pos_count++; }
                if (i < 0) { neg_count++; }
            }
            Console.WriteLine("\nPočet nul: {0}  Počet sudých: {1}  Počet lichých: {2}  počet záporných: {3} počet kladných: {4}\n", zero_count, even_count, odd_count, neg_count, pos_count);

            reset();

            foreach (int i in sude_pole)
            {
                Console.Write(i + " ");
                if (i == 0) { zero_count++; }
                if (i % 2 == 1) { odd_count++; }
                if (i % 2 == 0) { even_count++; }
                if (i > 0) { pos_count++; }
                if (i < 0) { neg_count++; }
            }
            Console.WriteLine("\nPočet nul: {0}  Počet sudých: {1}  Počet lichých: {2}  počet záporných: {3} počet kladných: {4}\n", zero_count, even_count, odd_count, neg_count, pos_count);

            void reset()
            {
                zero_count = 0; odd_count= 0; even_count= 0; pos_count= 0; neg_count= 0;
            }

        }
    }
}
