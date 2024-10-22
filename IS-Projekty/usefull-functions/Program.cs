using System;

namespace usefull_functions
{
    public class Functions
    {
        public static void Main(String[] args) { }

        public static Boolean is_parseable(string S)
        {
            Boolean result = true;
            try
            {
                int temp = int.Parse(S);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static int numeric_sum(int A)
        {
            int result = 0;
            while (A != 0)
            {
                result += A % 10;
                A /= 10;
            }
            return result;
        }

        public static int numeric_quant(int A)
        {
            int result = 1;
            while (A != 0)
            {
                result *= A % 10;
                A /= 10;
            }
            return result;
        }

        public static double round_to_half(double x)
        {
            double remainder = x % 1;

            if (remainder >= 0.25 && remainder <= 0.75)
            {
                return Math.Round(x, 0) + 0.5;
            }
            else
            {
                return Math.Round(x, 0);
            }
        }
    }
}