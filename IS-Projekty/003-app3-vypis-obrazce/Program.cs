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
            double tria_z=0;

            /*
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
            */

            Console.WriteLine("Zadej hodnoty pro trojuhelník x,y");

            tria_x = int.Parse(Console.ReadLine());
            tria_y = int.Parse(Console.ReadLine());

            if (tria_x < tria_y && tria_x != 0)
            {
                tria_z = Functions.round_to_half(tria_y / tria_x-1);
            }
            else if (tria_x > tria_y && tria_y != 0)
            {
                tria_z = Functions.round_to_half(tria_x / tria_y - 1);
            }
            else { Console.WriteLine("špatná kombinace čísel"); }

            double temp = tria_z;


            for (int i = 0; i < tria_x; i++)
            {
                if (i == 0) { Console.Write("██"); }
                else
                {
                    for (int j = 0; j < 2*tria_z; j++)
                    {
                        Console.Write("█");
                    }
                }

                Console.WriteLine();
                tria_z += temp;
            }

        }
    }
}


