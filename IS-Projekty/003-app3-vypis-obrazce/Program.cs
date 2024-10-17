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
            double tria_z;

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
            tria_z = Math.Sqrt(tria_x * tria_x + tria_y * tria_y);


            for (int i = 0; i < tria_x; i++)
            {
                for (int j = 0; j < tria_y; j++)
                {
                    for (int k = 0; k <= tria_z; k++)
                    {
                        if (k <= j && k <= i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                   
                }
                Console.WriteLine();
            }

        }
    }
}


