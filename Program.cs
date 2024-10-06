using System;
using System.Collections.Generic;

namespace szamrendszerek
{
    internal class Program
    {

        public static int bekeres()
        {
            int szam = 0;
            Console.Write("kérek a 10-es számrendszerben lévő számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            return szam;
        }
        public static void szamol()
        {
            int Bekertszam = bekeres();

            List<int> list = new List<int>();

            while (Bekertszam != 0)
            {
                if (Bekertszam % 2 == 0)
                {
                    list.Add(1);
                    Bekertszam %= 2;
                }
                else
                {
                    list.Add(0);
                    Bekertszam %= 2;
                }
            }

            Console.WriteLine("a szám binárisban:");

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i]);
            }

            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            szamol();
        }
    }
}

