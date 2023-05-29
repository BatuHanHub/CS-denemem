using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınız ne?");
            string ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad + " nasılsın?");
            string nasil = Console.ReadLine();
            Console.WriteLine("Bende " + nasil+" kaç yaşındasınız?");
            int yas = Convert.ToInt32(Console.ReadLine());
            int yas_farki = yas - 15;
            Convert.ToString(yas_farki);

            if (yas_farki > yas)
            {
                Console.WriteLine("Aramızda "+ yas_farki);
            }
            else if (yas == 15)
            {
                Console.WriteLine("Yaşıtız");
            }
            
            else
            {
                Console.WriteLine("Küçüğümsün");
            }
            Console.WriteLine("Kaç tane programlama dili biliyorsun");
            int dil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ben 5 tane dil biliyorum\nPython\nC/C++/C#\nPascal");
        }
    }
}
