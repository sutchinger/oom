using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;
using static System.Console;
using System.IO;
using Task_4.Gräber;

namespace Task_4
{
    class GrabArrayErstellen
    {

        public static void Run()
        {

            Pyramide a = new Pyramide("Ramses", 1);
            Pyramide b = new Pyramide("TutEnchAmun", 2);
            Pyramide c = new Pyramide("Echnaton", 8);
            ErdGrab d = new ErdGrab("Mayer", 4);
            ErdGrab e = new ErdGrab("Suchy", 12);
            ErdGrab f = new ErdGrab("Sandler", 7);


            IGrab[] array = new IGrab[] { a, b, c, d, e, f };

            /// Array ausgeben
            /// Array sortieren
            //array.OrderBy(grab=>grab.Name)
            Array.Sort(array, delegate (IGrab x, IGrab y) {
                return x.Index.CompareTo(y.Index);
            });
            foreach (var x in array)
            {

                WriteLine($"{x.Name} auf Nummer {x.Index} in einem Typ {x.Typ}; zum Inschrift erstellen: ");
                x.MachInschrift();
                WriteLine("\n");
            }

            /// Serialisieren / Deserialisieren
            string GrabListe1 = JsonConvert.SerializeObject(array);
            WriteLine("\nGrabliste1:\n" + GrabListe1);
            //File.Create(@"C:\gkkdfu\test.txt");
            try
            {
                File.WriteAllText(Path.GetTempPath() + "\\test.txt", GrabListe1);
            }
            catch (UnauthorizedAccessException p)
            {
                WriteLine(p.Message);
            }
            string GrabListe2 = File.ReadAllText(Path.GetTempPath() + "\\test.txt");

            WriteLine("\nGrabliste 2:\n" + GrabListe2);



            string P1 = JsonConvert.SerializeObject(a);
            WriteLine("\n****" + P1 + "***\n");
            Pyramide z = JsonConvert.DeserializeObject<Pyramide>(P1);
            WriteLine($"{z.Name} liegt auf Nummer {z.Index} in einem Typ {z.Typ}");

        }    
    }
}
