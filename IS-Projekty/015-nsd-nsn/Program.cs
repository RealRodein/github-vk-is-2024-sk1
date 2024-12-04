namespace _015_nsd_nsn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong i = 0;
            ulong nsd = 0;
            ulong nsn = 0;
            Console.Write("Zadej x: ");
            ulong x = ulong.Parse(Console.ReadLine());
            Console.Write("Zadej y: ");
            ulong y = ulong.Parse(Console.ReadLine());

            if (x < y)
            {
                i = y;
            }
            else
            {
                i = x;
            }

            for (ulong j = i; j > 0; j--) {
                if (x % j == 0 && y % j == 0) { 
                    nsd = j;
                    nsn = (x * y) / nsd;
                    break;
                }
            }

            Console.WriteLine("nsd: {0} nsn: {1}", nsd, nsn);
        }
    }
}
