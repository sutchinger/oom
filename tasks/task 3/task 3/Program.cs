using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace task_3
{
    public interface IGrab
    {
        string Name { get; set; }
        int Index { get; set; }
        string Typ { get; }
        void MachInschrift();
        

    }

    class Pyramide : IGrab
    {
        public Pyramide(string newName, int newIndex)
        {
            Name = newName;
            Index = newIndex;
        }

     
        public string Name { get; set; }
        public int Index { get; set; }
        public string Typ => "Pyramide";
        public void MachInschrift()
        {
            WriteLine("Sklavenarmee wird herangetrieben");
        }
       
       
       
    }

    class ErdGrab : IGrab
    {
        public ErdGrab(string newName, int newIndex)
        {
            Name = newName;
            Index = newIndex;
        }


        public string Name { get; set; }
        public int Index { get; set; }
        public string Typ => "Erdgrab";
        public void MachInschrift()
        {
            WriteLine("Steinmetz wird beauftragt");
        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            Pyramide a = new Pyramide("Ramses", 1);
            Pyramide b = new Pyramide("TutEnchAmun", 2);
            Pyramide c = new Pyramide("Echnaton", 3);
            ErdGrab d = new ErdGrab("Mayer", 4);
            ErdGrab e = new ErdGrab("Suchy", 5);
            ErdGrab f = new ErdGrab("Sandler", 6);

            IGrab[] array = new IGrab[] { a, b, c, d, e, f};

            foreach (var x in array)
            {
                WriteLine($"{x.Name} auf Nummer {x.Index} in einem Typ {x.Typ}; Inschrift: ");
                x.MachInschrift();
                WriteLine("\n");
            }

            //WriteLine($"{a.Name} liegt auf Nummer {a.Index} in einem Typ {a.Typ}");


        }
    }
}
