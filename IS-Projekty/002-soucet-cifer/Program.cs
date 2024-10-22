using System.Collections;
using usefull_functions;

namespace _002_soucet_cifer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input;
            String cont;
            int num_sum = 0;
            int num_quant = 1;


            do
            {
                num_sum = 0;
                num_quant = 1;

                Console.Clear();
                Console.WriteLine("Zadávej čísla:");
                do
                {
                    input = Console.ReadLine();
                    if (Functions.is_parseable(input))
                    {
                        num_sum += Functions.numeric_sum(int.Parse(input));
                        num_quant *= Functions.numeric_quant(int.Parse(input));
                    }
                    else break;

                } while (true);

                Console.WriteLine("result for numeric sum is: " + num_sum);
                Console.WriteLine("result for numeric quant is: " + num_quant);
                Console.WriteLine("continue?");
                cont = Console.ReadLine();

            } while (cont == "Y" || cont == "y");
        }
    }
}
