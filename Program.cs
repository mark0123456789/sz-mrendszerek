using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<int> list = new List<int>();

            while (bekeres() != 0) 
            {
                if (bekeres() % 2 == 0)
                {
                    list.Add(0);
                }
                else 
                { 
                    list.Add(1);
                }
                Console.WriteLine(" a bonáris szám = ");
        }
        static void Main(string[] args)
        {
                szamol();
        }
    }
}

