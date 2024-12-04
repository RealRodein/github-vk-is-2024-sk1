using usefull_functions;
namespace _017_2d_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte počet řádků: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("\nZadejte počet sloupců: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nZadejte dolní mez intervalu: ");
            int dm = int.Parse(Console.ReadLine());
            Console.Write("\nZadejte horní mez intervalu: ");
            int hm = int.Parse(Console.ReadLine());
            Console.Write("\nZadejte cislo k nalezeni: ");
            int temp = int.Parse(Console.ReadLine());

            int[,] array = Functions.random_array_2d(n,m,dm,hm);
            Functions.array_out_2d(array);
            int x = Functions.find_in_2d_array(array, temp);
            Console.WriteLine("cislo bylo {0}, bylo nalezeno {1}krat",temp,x);



        }
    }
}
