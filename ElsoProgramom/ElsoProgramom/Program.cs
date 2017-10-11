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
            int d=Osszead(5, 7,9);
            Console.WriteLine("a három szám eredménye: {0}", d);
            int x = Szoroz(3, 8);
            Console.WriteLine("a két szám szorzata: {0} {1}", x,d);
            Console.ReadLine();

        }


        // ez egy metódus, az a neve, hogy Osszead, három paramétere van mindhárom egész szám (int). 
        //A metódusnak van egy visszatérési értéke, tehát valami kijön ebből a hívásból.
        //

        static int Osszead(int a, int b, int c)
        {
            return a + b + c;
        }

        //a metódus szignatúrája az első sor, melynek tartalma a static, az int (visszatérési érték típusa)
        // az Osszead a metódus neve, ezt követően a paramétereket tartalmazó zárójel van
        //a paraméterek típusból és névből állnak, vesszővel vannak elválasztva
        //a metódus szignatúráját az implementácó követi kapcsos zárójelben és amennyiben adtunk meg visszatérési 
        //típust a szignatúrában, akkor a return-nek legalább egyszer szerepelnie kell

        static void Kiir()
        {
            Console.WriteLine(szoveg, 2, "alma");
        }

        static void Kiir2()
        {
            Console.WriteLine(szoveg, "alma", 2);
        }

        static int Szoroz (int a, int b)
        {
            int c = a * b;
            return c;
        }

    }
}
