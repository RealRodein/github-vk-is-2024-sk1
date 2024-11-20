using usefull_functions;

namespace _011a_intervaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pozadovanou delku pole, dm, hm:");
            int n = int.Parse(Console.ReadLine());
            int dm = int.Parse(Console.ReadLine());
            int hm = int.Parse(Console.ReadLine());
            double quater = ((hm + 1) - dm) / 4;
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0;

            int[] array = Functions.random_array(n, dm, hm);

            Functions.array_out(array);
            foreach (int i in array)
            {
                if (i <= quater)
                {
                    count1++;
                }
                else if (i <= quater + quater)
                {
                    count2++;
                }
                else if (i <= quater + quater + quater)
                {
                    count3++;
                }
                else if (i <= hm)
                {
                    count4++;
                }
            }

            Console.WriteLine("v intervalu <{0}-{1}>: {2}", dm, quater, count1);
            Console.WriteLine("v intervalu ({0}-{1}>: {2}", quater, quater + quater, count2);
            Console.WriteLine("v intervalu ({0}-{1}>: {2}", quater + quater, quater + quater + quater, count3);
            Console.WriteLine("v intervalu ({0}-{1}>: {2}", quater + quater + quater, hm, count4);



        }
    }
}
