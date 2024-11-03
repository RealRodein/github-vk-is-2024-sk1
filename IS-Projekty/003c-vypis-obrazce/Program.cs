using usefull_functions;

namespace _003c_vypis_obrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, select;
            bool loop = true;
            char temp;

            while(loop == true)
            {
                Console.Clear();
                Console.WriteLine("~~~~~~ Vitejte ve vypisovani obrazku ~~~~~~\n");
                Console.Write("zadejte delku obrazce: ");
                while (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.Write("zadejte delku obrazce: ");
                }
                Console.Write("zadejte cislo obrazku.\n(aktualne zhotovene jsou 1,4,5,6,7,10,11,12,13,14,20): ");
                while (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.Write("zadejte cislo obrazku: ");
                }
                
                pic_out(pic_select(size,select));

                Console.Write("\npokracovat? (y/Y): ");
                temp = Console.ReadKey().KeyChar;
                loop = (temp == 'Y' || temp == 'y' || temp == 'z' || temp == 'Z');  
                
            }

        }
        public static bool[,] pic_select(int size, int num)
        {
            bool[,] result = new bool[size, size];
            double half = result.GetLength(0) / 2;
            int int_half = (int)Math.Round(half);
            int lower_half = (int)Math.Floor(half);
            int upper_half = (int)Math.Ceiling(half);
            int iswitch = 0;
            int cont = 1;
            


            do
            {
                cont = 1;
                switch (num)
                {
                    case 1:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (x == y)
                                {
                                    result[x, y] = true;
                                    result[x, result.GetLength(1) - y - 1] = true;

                                }
                                else if (y == int_half)
                                {
                                    result[x, y] = true;
                                }
                                else if (x == int_half)
                                {
                                    result[x, y] = true;
                                }
                            }
                        }
                        break;
                    case 4:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y == 0 || y == result.GetLength(0) - 1)
                                {
                                    result[x, y] = true;
                                }
                                else if (y == x)
                                {
                                    result[x, result.GetLength(1) - y - 1] = true;
                                }
                            }
                        }
                        break;
                    case 5:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y == 0 || y == result.GetLength(0) - 1)
                                {
                                    result[x, y] = true;
                                }
                                else if (y == x)
                                {
                                    result[x, result.GetLength(1) - y - 1] = true;
                                }
                            }
                        }
                        result = Functions.flip_array(result);
                        break;
                    case 6:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y == 0 || y == result.GetLength(0) - 1)
                                {
                                    result[x, y] = true;
                                }
                                else if (y == x)
                                {
                                    result[x, result.GetLength(1) - y - 1] = true;
                                }
                            }
                        }
                        result = Functions.rotate_array_90(result);
                        break;
                    case 7:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y == 0 || y == result.GetLength(0) - 1)
                                {
                                    result[x, y] = true;
                                }
                                else if (y == x)
                                {
                                    result[x, result.GetLength(1) - y - 1] = true;
                                }
                            }
                        }
                        result = Functions.flip_array(Functions.rotate_array_90(result));
                        break;
                    case 10:
                        iswitch = 0;
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            if (y % 2 == 1)
                            {
                                if (iswitch % 2 == 0)
                                {
                                    result[result.GetLength(0) - 1, y] = true;
                                    iswitch++;
                                }
                                else
                                {
                                    result[0, y] = true;
                                    iswitch++;
                                }
                            }


                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y % 2 == 0)
                                {
                                    result[x, y] = true;
                                }

                            }
                        }
                        break;
                    case 11:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            if (y % 2 == 1)
                            {
                                if (iswitch % 2 == 0)
                                {
                                    result[result.GetLength(0) - 1, y] = true;
                                    iswitch++;
                                }
                                else
                                {
                                    result[0, y] = true;
                                    iswitch++;
                                }
                            }


                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (y % 2 == 0)
                                {
                                    result[x, y] = true;
                                }

                            }
                        }
                        result = Functions.rotate_array_90(result);
                        result = Functions.flip_array(result);
                        break;
                    case 12:
                        iswitch = 1;
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            if (iswitch % 2 == 0)
                            {
                                result[0, y] = true;
                            }
                            iswitch++;

                            for (int x = 1; x < result.GetLength(0); x++)
                            {
                                if (result[x - 1, y] == false)
                                {
                                    result[x, y] = true;
                                }
                            }
                        }
                        break;
                    case 13:
                        half = result.GetLength(1)/2;
                        for (int y = 0; y < result.GetLength(1); y++)
                        {
                            if (y <= half)
                            {
                                result[0, y] = true;
                                result[lower_half, y] = true;
                            }
                            else if(y >= half){
                                result[result.GetLength(1) - 1, y] = true;
                                result[upper_half, y] = true;
                            }


                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (x <= half)
                                {
                                    result[x, 0] = true;
                                    result[x, lower_half] = true;
                                }
                                else if (x >= half)
                                {
                                    result[x,result.GetLength(1) - 1] = true;
                                    result[x, upper_half] = true;
                                }

                            }
                        }
                        result = Functions.rotate_array_90(result);
                        result = Functions.flip_array(result);
                        break;
                    case 14:
                        for (int y = 0; y < result.GetLength(1); y++)
                        {

                            for (int x = 0; x < result.GetLength(0); x++)
                            {
                                if (x >= result.GetLength(0) / 2 && y < result.GetLength(1) / 2)
                                {
                                    result[x, y] = true;
                                }
                                else if (x < result.GetLength(0) / 2 && y >= result.GetLength(1) / 2)
                                {
                                    result[x, y] = true;
                                }
                            }
                        }
                        break;
                    case 20:
                        iswitch = 0;
                        for (int y = 0; y < result.GetLength(1); y += 2)
                        {
                            if (iswitch % 2 == 0)
                            {
                                result[0, y] = true;
                                result[1, y] = true;
                                result[0, y + 1] = true;
                                result[1, y + 1] = true;
                            }
                            iswitch++;

                            for (int x = 2; x < result.GetLength(0); x += 2)
                            {
                                if (result[x - 2, y] == false)
                                {
                                    result[x, y] = true;
                                    result[x + 1, y] = true;
                                    result[x, y + 1] = true;
                                    result[x + 1, y + 1] = true;
                                }
                            }
                        }
                        break;
                    default:
                        Console.Write("spatne cislo/nevypracovane.\nzvolte jine cislo (1,4,5,6,7,10,11,12,14,20): ");
                        while (!int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.Write("zadejte jine cislo obrazku: ");
                        }
                        cont = 0;
                        break;

                }
            } while (cont != 1);
            return result;
        }

        public static int[,] frame_make(int n)
        {
            int[,] result;

            if (n < 11)
            {
                result = small_frame(n);
            }
            else
            {
                result = big_frame(n);
            }

            return result;
        }

        public static int[,] small_frame(int n)
        {
            int[,] result = new int[n + 2, n + 2];
            result[1, 1] = -2;

            for (int y = 2; y < result.GetLength(1); y++)
            {
                result[0, y] = y - 1;
                result[1, y] = -3;
                for (int x = 2; x < result.GetLength(0); x++) // < out of bounds
                {
                    result[x, 1] = -1;
                    result[x, 0] = x - 1;

                }
            }

            return result;
        }

        public static int[,] big_frame(int n)
        {
            int[,] result = new int[n + 2, n + 3];
            result[1, 2] = -2;

            for (int y = 3; y < result.GetLength(1); y++)
            {
                result[0, y] = y - 2;
                result[1, y] = -3;

                for (int x = 2; x < result.GetLength(0); x++)
                {
                    result[x, 2] = -1;

                    if (x < 11)
                    {
                        result[x, 1] = x - 1; 
                    }
                    else if (x % 2 == 1)
                    {
                        result[x, 1] = x - 1;
                    }
                    else
                    {
                        result[x, 0] = x - 1;
                        result[x, 1] = -4;
                    }
                }
            }

            return result;
        }

        static void frame_out(int[,] array)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for(int x = 0; x < array.GetLength(0); x++)
                {
                    switch (array[x,y])
                    {
                        case 0: 
                            Console.Write("  ");
                            break;
                        case -1:
                            Console.Write("══");
                            break;
                        case -2: 
                            Console.Write("╔═");
                            break;
                        case -3:
                            Console.Write("║ ");
                            break;
                        case -4:
                            Console.Write("↓ ");
                            break;
                        default:
                            if (array[x, y] < 10)
                            {
                                Console.Write(array[x, y] + " ");
                            }
                            else
                            { 
                                Console.Write(array[x, y]);
                            } 
                            break;
                    }
                }
                Console.WriteLine();
            }



        }

        public static void pic_out(bool[,] array)
        {
            Console.Clear();
            Console.WriteLine("~~~~~~ Vitejte ve vypisovani obrazku ~~~~~~\n");

            frame_out(frame_make(array.GetLength(0)));
            if(array.GetLength(0) < 11)
            {
                Functions.array_bool_out(array,4,4);
            }
            else
            {
                Functions.array_bool_out(array,4, 5);
            }
        }
    }
}
