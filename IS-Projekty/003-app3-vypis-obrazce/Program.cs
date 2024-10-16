using System.Collections;

namespace _003_app3_vypis_obrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rect_a;
            int rect_b;
            int tria_x;
            int tria_y;
            int tria_z;

            Console.WriteLine("Zadej hodnoty pro obdélník");
            rect_a = int.Parse(Console.ReadLine());
            rect_b = int.Parse(Console.ReadLine());

            for (int i = 0; i < rect_a; i++)
            {
                for (int j = 0; j < rect_b; j++)
                {
                    Console.Write("██");
                }
                Console.WriteLine();
            }

        }
    }
}