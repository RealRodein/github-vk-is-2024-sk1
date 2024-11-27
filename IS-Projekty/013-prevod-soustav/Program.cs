namespace _013_prevod_soustav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("zadej cislo v desitkove: ");
            uint decimal_num = uint.Parse(Console.ReadLine());
            Console.Write("zadej cilovou soustavu (max.:16): ");
            uint base_num = uint.Parse(Console.ReadLine());

            string vysledek = dec_to_base(decimal_num, base_num);
            Console.WriteLine("vysledek v {0} soustave: {1}", base_num, vysledek);
        }

        static string dec_to_base(uint num, uint @base)
        {
            if (num == 0) return "0";

            string result = "";
            while (num > 0)
            {
                uint temp = num % @base;
                result = (temp >= 10 ? ((char)('A' + temp - 10)).ToString() : temp.ToString()) + result;
                num /= @base;
            }
            return result;
        }
    }
}
