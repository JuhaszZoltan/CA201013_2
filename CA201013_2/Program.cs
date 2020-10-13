using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201013_2
{
    class DiakC
    {
        public string nev;
        public int kor;
    }
    struct DiakS
    {
        public string nev;
        public int kor;
    }

    class Program
    {
        static void Main()
        {
            var d1 = new DiakC { nev = "Osztály Dezső", kor = 18, };
            var d2 = new DiakS { nev = "Struktúra István", kor = 12, };
            var referenciaD1 = d1;
            var masolatD2 = d2;
            referenciaD1.nev = "Géza";
            masolatD2.nev = "Imre";
            Console.WriteLine($"eredeti: {d1.nev}");
            Console.WriteLine($"eredeti: {d2.nev}");
            Console.WriteLine($"másolat: {referenciaD1.nev}");
            Console.WriteLine($"másolat: {masolatD2.nev}");

            //továbbá az, hogy struktúra alapértelmezett konstruktortát NEM tudod elfedni/elrejteni
            Console.ReadKey();
        }
    }
}
