using System;

namespace hesapla
{
   
 
class diktdörtgen
    {
        static int Alan(int kenar, int yükseklik)
        {
            int alan = kenar * yükseklik;
            return alan;
        }
        static int Cevre(int kenar, int yükseklik)
        {
            int cevre = 2 * (kenar + yükseklik);
            return cevre;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kenarı giriniz.");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yükseklik giriniz.");

            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin Alanı {0}", Alan(b, h));

            Console.WriteLine("Dikdörtgenin Çevresi {0}", Cevre(b, h));

            Console.ReadKey();
        }
    }

}
