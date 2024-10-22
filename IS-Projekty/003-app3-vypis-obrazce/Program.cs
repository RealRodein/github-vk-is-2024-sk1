using System.Collections;
using usefull_functions;

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
            double tria_z;
            int temp;

            
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
            Console.Clear(); 
            

            Console.WriteLine("Zadej hodnoty pro trojuhelník x,y");

            tria_x = int.Parse(Console.ReadLine());
            tria_y = int.Parse(Console.ReadLine());
            tria_z = (double)tria_y / tria_x;

            for (int i = 1; i <= tria_x; i++) 
            {
                Console.Write("    ");
                temp = (int)Math.Round(i * tria_z);

                for (int j = 0; j < temp; j++)
                {
                    Console.Write("██");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}


