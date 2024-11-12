using usefull_functions;

namespace _005_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                //Console.WriteLine("zadej delku pole, hranici minima a hranici maxima:");
                //int n = int.Parse(Console.ReadLine());
                //int min = int.Parse(Console.ReadLine());
                //int max = int.Parse(Console.ReadLine());
                //int[] array = Functions.random_array(n, min, max);

                int[] array = Functions.random_array(20, 3, 10);
                Functions.array_out(array);
                //int[] array2 = Functions.dump_sort_array(array);
                //Functions.array_out(array2);
                Console.WriteLine("min: {0}, max: {1}", Functions.array_return_min(array), Functions.array_return_max(array));
                Console.Write("pos min: ");
                foreach(int i in Functions.array_min_pos(array))
                {
                    Console.Write(i + " ");
                }
                Console.Write("\npos max: ");
                foreach (int i in Functions.array_max_pos(array))
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            } while (Console.ReadLine() == "y");
        }
    }
}
