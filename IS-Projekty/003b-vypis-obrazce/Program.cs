namespace _003b_vypis_obrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tria_x;
            int tria_y;
            double tria_z;
            int temp;

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
