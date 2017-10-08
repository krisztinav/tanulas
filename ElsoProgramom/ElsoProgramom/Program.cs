using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoProgramom
{
    class Program
    {
        static string szoveg = "voldemort2 {0} {1}";

        static void Main(string[] args)
        {
            Kiir();
            Kiir2();
            int c=Osszead(5, 7);
            Console.WriteLine("a két szám eredménye: {0}", c);
            Console.ReadLine();
        }

        static int Osszead(int a, int b)
        {
            return a + b;
        }

        static void Kiir()
        {
            Console.WriteLine(szoveg, 2, "alma");
        }

        static void Kiir2()
        {
            Console.WriteLine(szoveg, "alma", 2);
        }
    }
}
