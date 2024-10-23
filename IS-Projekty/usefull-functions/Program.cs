using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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

        public static int[] random_array(int n, int low, int high)
        {
            Random random = new Random();

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(low, high);
            }

            return array;
        }

        public static int[] random_array_even(int n, int low, int high)
        {
            Random random = new Random();
            int temp;
            Boolean proceed=false;
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                proceed = false;
                while (!proceed)
                {
                    temp = random.Next(low, high);
                    if(temp % 2 == 0)
                    {
                        array[i] = temp;
                        proceed = true;
                    }
                }
            }
            return array;
        }

        public static int[] random_array_odd(int n, int low, int high)
        {
            Random random = new Random();
            int temp;
            int[] array = new int[n];
            Boolean proceed = false;

            for (int i = 0; i < array.Length; i++)
            {
                proceed = false;
                while (!proceed)
                {
                    temp = random.Next(low, high);
                    if (temp % 2 == 1)
                    {
                        array[i] = temp;
                        proceed = true;
                    }
                }
            }
            return array;
        }


    }
}