using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    internal class Program
    {
       

        static int AsalMi(int sayi)
        {
            if (sayi < 2)
            {
                return 0;
            }

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }

            return sayi;
        }


        static void Main(string[] args)
        {

            int sifre = 547, p = 59, q = 43;

            int n = p*q;
            int totient = (p-1)*(q-1);

            Random random = new Random();
            int e;
            while (true)
            {
                e = random.Next(2, totient);
                if (AsalMi(e)!=0)
                {
                    Console.WriteLine(AsalMi(e));
                    break;
                }
                else
                {
                    continue;
                }
            }

            int d;
            do
            {
                d = random.Next(2, totient);
            } while ((d * e) % totient != 1);

            Console.WriteLine("Özel Anahtar (d): " + d);




        }
    }
}
