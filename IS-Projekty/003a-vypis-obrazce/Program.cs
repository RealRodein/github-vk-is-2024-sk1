using System.Collections;

namespace _003_vypis_obrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rect_a;
            int rect_b;


            Console.WriteLine("Zadej hodnoty pro obdélník a,b");
            rect_a = int.Parse(Console.ReadLine());
            rect_b = int.Parse(Console.ReadLine());

            for (int i = 0; i < rect_a; i++)
            {
                Console.Write("    ");
                for (int j = 0; j < rect_b; j++)
                {

                    Console.Write("██");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}


