namespace _013_prevod_soustav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("zadej cislo v desitkove: ");
            int decimal_num = int.Parse(Console.ReadLine());
            Console.Write("zadej cilovou soustavu (max.:16): ");
            int base_num = int.Parse(Console.ReadLine());

            string vysledek = dec_to_base(decimal_num, base_num);
            Console.WriteLine("Výsledek v cílové soustavě: " + vysledek);
        }

        static string dec_to_base(int num, int @base)
        {
            if (num == 0) return "0";

            string result = "";
            while (num > 0)
            {
                int temp = num % @base;
                result = (temp >= 10 ? ((char)('A' + temp - 10)).ToString() : temp.ToString()) + result;
                num /= @base;
            }
            return result;
        }
    }
}
