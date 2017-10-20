using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Zaposlenik
    {
        public string Ime;
        public string Prezime;

        public void IspisImePrezime()
        {
            Console.WriteLine(Ime + " " + Prezime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik Marko = new Zaposlenik();
            Marko.Ime = "Marko";
            Marko.Prezime = "Marković";

            Marko.IspisImePrezime();
            Console.ReadKey();
        }
    }
}
