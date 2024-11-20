namespace _010_konvergence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pozadovany pocet iteraci (max 15 pls):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vypočítaná hodnota π: " + make_pi(n));
            Console.WriteLine("Vypočítaná hodnota φ: " + make_gold(n));
            Console.WriteLine("Vypočítaná hodnota e: " + make_e(n));
            Console.WriteLine("Vypočítaná hodnota √2: " + make_sqrt2(n));
            Console.WriteLine("Vypočítaná hodnota ln(2): " + make_ln2(n));
        }

        public static double make_pi(int n)
        {
            double pi = 0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            pi *= 4;
            return pi;
        }
        public static double make_e(int n)
        {
            double e = 1;
            for (int i = 1; i <= n; i++)
            {
                e += 1.0 / factorial(i);
            }
            return e;
        }

        public static double make_gold(int n)
        {
            double phi = 0;
            double temp = 1;
            for (int i = 0; i < n; i++)
            {
                phi = 1 + 1 / (phi + 1);
                temp = phi;
            }

            return phi;
        }

        public static double make_ln2(int n)
        {
            double ln2 = 0;
            for (int i = 1; i <= n; i++)
            {
                ln2 += Math.Pow(-1, i + 1) / i;
            }
            return ln2;
        }

        public static double make_sqrt2(int n)
        {
            double x = 1.0;
            double precision = Math.Pow(10, -n);

            while (Math.Abs(x * x - 2) > precision)
            {
                x = 0.5 * (x + 2 / x);
            }

            return x;
        }

        static int factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
