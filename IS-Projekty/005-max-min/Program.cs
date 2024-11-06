using usefull_functions;

namespace _005_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] array = Functions.random_array(10, 0, 100);
                Functions.array_out(array);
                int[] array2 = Functions.dump_sort_array(array);
                Functions.array_out(array2);
                Console.WriteLine("min: {0}, max: {1}", Functions.array_return_min(array), Functions.array_return_max(array));
                Console.WriteLine("pos min:{0}, max:{1}", Functions.array_return_min_pos(array), Functions.array_return_max_pos(array));
            } while (Console.ReadLine() == "y");
        }
    }
}
