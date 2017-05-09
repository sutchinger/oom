using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE3
{

    abstract class Artikel
    {
        public string Name { get; }
        public Artikel(string name)
        {
            Name = name;
            
        }
        public abstract decimal GetPreis(); //mit abstract anzeigen, dass nicht vergessen wurde
                                            //Klasse muss abstract sein wenn abstrakte Operation vorhanden
                                            //virtual statt abstract kann auch in nicht abstracten klassen sein

    }

    class Katze : Artikel
    {
        public int Leben { get; private set; } = 7;
        public void Sterben() => Leben--;
        public Katze(string name, int leben) : base(name) // nimmt constructor aus basis Klasse
        {
            Leben = leben > 0 ? leben : 1;
            
        }
        //Überschreiben von abstrakter Funktion
        public override decimal GetPreis() //override damit man nicht vererbte Funktion überschreibt
        {
            return 123;

        }

    }
    class Hund : Artikel
    {
        public string Rasse { get; }
        public Hund(string name, string rasse) : base(name)
        { }
        public override decimal GetPreis() //override damit man nicht vererbte Funktion überschreibt
        {
            return 456;

        }
    }

    

    class Program
    {
        static void PrintArtikel(Artikel x)
        {
            Console.WriteLine($"[name: {x.Name}; Preis {x.GetPreis()}]");
        }

        static double MalZwei(double x) { return x * 2; }
        static double Deg2Rad(double x) => x * Math.PI / 180;
        

        static void Main(string[] args)
        {
            Func<double, double> a = MalZwei; //erste input, zweite return

            var degrees = new[] { 0.0, 45.0, 90.0, 135.0, 180 };
            //var radians = Map(degrees, )

            Console.WriteLine(a(14));
            
            
            
            /*
            // var a = new Artikel("Artikel A");
            var b = new Katze("Katze K", 11);
            var c = new Hund("Hund H", "Dackel");

            PrintArtikel(c);
            PrintArtikel(b);
            */
        }
    }
}
