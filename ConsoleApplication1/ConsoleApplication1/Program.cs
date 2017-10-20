using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Zaposlenik
    {
        public string Ime ="Default vrijednost, ";
        public string Prezime ="Default vrijednost, ";

        public virtual void IspisImePrezime()
        {
            Console.WriteLine(Ime + " " + Prezime + " zaposlenik.");
        }
    }

    public class PolaVremena : Zaposlenik
    {
        public override void IspisImePrezime()
        {
            Console.WriteLine(Ime + " " + Prezime + " Pola vremena.");
        }
    }

    public class PunoVrijeme : Zaposlenik
    {
        public override void IspisImePrezime()
        {
            Console.WriteLine(Ime + " " + Prezime + " Puno vrijeme.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik[] zaposlenici = new Zaposlenik[3];
            zaposlenici[0] = new Zaposlenik();
            zaposlenici[1] = new PolaVremena();
            zaposlenici[2] = new PunoVrijeme();

            foreach ( Zaposlenik z in zaposlenici)
            {
                z.IspisImePrezime();
            }

            Console.ReadKey();
        }
    }
}
