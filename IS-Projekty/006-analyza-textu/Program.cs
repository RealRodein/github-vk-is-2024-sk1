namespace _006_analyza_textu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte text:");
            String to_analyze = Console.ReadLine();
            int samohlasky = 0;
            int souhlasky = 0;
            int ostatnich = 0;

            foreach (char c in to_analyze) {
                if ("eyuioaěáíéúůEYUIOAÁÝÍÉÚŮ".Contains(c)) 
                {
                    samohlasky++;
                }
                else if ("qwrtpsdfghjklxcvbnmščřžQWRTPSDFGHJKLZXCVBNMŠČŘŽŤŇ".Contains(c))
                {
                    souhlasky++;
                }
                else
                {
                    ostatnich++;
                }
            }

            Console.WriteLine("pocet samohlasek: {0}\npocet souhlasek: {1}\npocet ostatnich: {2}", samohlasky, souhlasky, ostatnich);
            Console.ReadKey();

        }
    }
}
