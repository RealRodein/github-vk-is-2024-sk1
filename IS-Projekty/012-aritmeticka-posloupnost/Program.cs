namespace _012_aritmeticka_posloupnost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("pocet clenu: ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("difference: ");
            int diference = int.Parse(Console.ReadLine());

            Console.Write("prvni clen: ");
            int first = int.Parse(Console.ReadLine());

            int total = 0;
            Console.Write("posloupnost: ");
            for (int i = count; i != 0; i--)
            {
                Console.Write(first + " ");
                total += first;
                first += diference;
            }

            // Výpis součtu
            Console.WriteLine("\ncelkem: " + total);
        }
    }
}
