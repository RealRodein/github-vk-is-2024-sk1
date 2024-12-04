using System;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace _014_kombinovane_zadani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 5, 9, 7, 6, 6, 5, 8, 9, 1, 3, 4, 9, 8 };
            Array.Sort(array);
            Array.Reverse(array);
            int temp = array[0];
            int index = 2;
            int median = array[array.Length/2];
            int treti = 0;


            for (int i = 1; i < array.Length; i++) { 
                if(temp > array[i] && index == 2)
                {
                    Console.Write("Druhé největší číslo: {0}\n", array[i]);
                    index++;
                    temp = array[i];
                }
                if (temp > array[i] && index == 3)
                {
                    Console.Write("Třetí největší číslo: {0}\n", array[i]);
                    index++;
                    treti = array[i];
                    temp = array[i];
                }
                if (temp > array[i] && index == 4)
                {
                    Console.Write("Čtvrté největší číslo: {0}\n", array[i]);
                    index++;
                    temp = array[i];
                }
            }

            Console.Write("Medián generovaných čísel = {0}\n", median );
            
            int temp2 = temp;
            string Bin = "";

            while (temp2 > 0)
            {
                Bin = temp2 % 2 + Bin;
                temp2 /= 2;
            }

            Console.WriteLine(Bin);
            Console.Write("{0} v binární soustavě = {1}\n", temp2, Bin);

            bool[,] pole = new bool[treti, median];
            bool[,] pole2 = new bool[median, treti];
            double treti_polovin = pole.GetLength(0) / 2;
            double median_polovin = pole2.GetLength(0) / 2;

            for (int i = 0; i < treti; i++) {
                for (int j = 0; j < median; j++)
                {
                    if (i == treti_polovin-1 || i == treti_polovin)
                    {
                        pole[i,j] = true;
                        pole2[j, i] = true;
                    }
                    if (j == median_polovin || j == median_polovin-1 || j == median_polovin-2)
                    {
                        pole[i, j] = true;
                        pole2[j, i] = true;
                    }
                }
            }
            array_bool_out(pole);
            Console.WriteLine();
            array_bool_out(pole2);


        }

        static int[] shaker_sort(int[] array)
        {
            int[] result = new int[array.Length];
            int temp;

            for (int x = 0; x < result.Length / 2; x++)
            {
                for (int i = x; i < result.Length - x - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                    }
                }

                for (int j = result.Length - x - 2; j > x; j--)
                {
                    if (result[j] < result[j - 1])
                    {
                        temp = result[j];
                        result[j] = result[j - 1];
                        result[j - 1] = temp;
                    }
                }
            }

            return result;
        }

        static int[] max(int[] array) {
            int[] result = new int[2];
            int count = 1;
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }
            result[0] = max;
            result[1] = count;

            return result;
        }

        static int[] min(int[] array)
        {
            int[] result = new int[2];
            int count = 1;
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    count = 1;
                }
                else if (array[i] == min)
                {
                    count++;
                }
            }
            result[0] = min;
            result[1] = count;

            return result;
        }

        static int[] return_indexes(int[] array, int n)
        {
            int count = 0;
            int index = 0;

            foreach (int i in array) {
                if(i == n) count++;
            }

            int[] result = new int[count];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == n)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }

        public static void array_bool_out(bool[,] array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    if (array[x, y] == true)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
