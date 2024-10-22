using System.Numerics;
using System.Threading;

namespace _001_vypis_rady
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean procceed = false;
            String again;
            int first;
            int goal;
            int step;

            do
            {
                Console.Clear();

                do
                {
                    Console.WriteLine("Zadej startoní číslo");
                    first = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zadej cílové číslo");
                    goal = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zadej krok");
                    step = int.Parse(Console.ReadLine());

                    procceed = (goal > first && step > 0);
                    if (procceed == false)
                    {
                        Console.WriteLine("špatná kombinace čísel \n zadej klávesu pro pokračování");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (procceed != true);

                Console.WriteLine();

                while (first <= goal)
                {
                    Console.WriteLine(first);
                    first = first + step;
                }

                Console.WriteLine("Pro opakování Y/y");
                again = Console.ReadLine();

            } while (again == "Y" || again == "y");




        }
    }
}
