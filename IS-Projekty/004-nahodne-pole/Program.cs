using System.Numerics;
using usefull_functions;

namespace _004_nahodne_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            }
            Console.WriteLine();
            foreach (int i in liche_pole)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine() ;
            foreach (int i in sude_pole)
            {
                Console.Write(i + " ");
            }



        }
    }
}
