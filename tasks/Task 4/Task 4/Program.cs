using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;
using static System.Console;
using System.IO;

namespace task_4
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
            {
                if(Name == "")
                {
                    Name = "Mumie X";
                }
            }
            Index = newIndex;
            {
                Index = Index > 0 ? Index : 1;

            }
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
            {
                if (Name == "")
                {
                    Name = "John Doe";
                }
            }
            Index = newIndex;
            {
                Index = Index > 0 ? Index : 1;

            }
        }
       

        public int Index { get; set; }
        public string Name { get; set; }
        
        public string Typ => "Erdgrab";
        public void MachInschrift()
        {
            WriteLine("Steinmetz wird beauftragt");
        }
    }
    class UrnenGrab : IGrab
    {
        public UrnenGrab(string newName, int newIndex)
        {
            Name = newName;
            {
                if (Name == "")
                {
                    Name = "Salz Gurke";
                }
            }
            Index = newIndex;
            {
                Index = Index > 0 ? Index : 1;

            }
        }
        

        public int Index { get; set; }
        public string Name { get; set; }

        public string Typ => "Urnengrab";
        public void MachInschrift()
        {
            WriteLine("Ettikettiermaschine wird aus dem Keller geholt");
        }


    }

    class Program
    {

        static void Main(string[] args)
        {

            Pyramide a = new Pyramide("Ramses",1);
            Pyramide b = new Pyramide("TutEnchAmun",2);
            Pyramide c = new Pyramide("Echnaton",8);
            ErdGrab d = new ErdGrab("Mayer",4);
            ErdGrab e = new ErdGrab("Suchy",12);
            ErdGrab f = new ErdGrab("Sandler",7);

            
            IGrab[] array = new IGrab[] { a, b, c, d, e, f };

            /// Array ausgeben
            /// Array sortieren
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
            WriteLine("\n****"+P1+"***\n");
            try
            {
                Pyramide z = JsonConvert.DeserializeObject<Pyramide>(P1);
                WriteLine($"{z.Name} liegt auf Nummer {z.Index} in einem Typ {z.Typ}");
            }
            
            catch (Exception)
            {

            }
            


            /// Manuelle Grab Vergabe
            char grabWahl = 'y';
            var neu = new List<IGrab>();
            
            string tempName;
            int tempIndex = 0;
            
            do
            {
                WriteLine("\nNeues Grab vergeben:\nE: ErdGrab\nP: Pyramide\nU: Urnengrabx: beenden");
                /// Auswahl einlesen und Exeption Handling
                try
                {
                    grabWahl = char.Parse(ReadLine());
                    //grabWahl = ReadKey().KeyChar;
                }
                catch (FormatException p)
                {
                    WriteLine(p.Message);
                }
              
                switch (grabWahl)
                {
                    case 'p':
                    case 'P':

                        tempName = GrabEingabe(ref tempIndex);
                        neu.Add(new Pyramide(tempName, tempIndex));
                        break;
                    case 'e':
                    case 'E':
                        tempName = GrabEingabe(ref tempIndex);

                        neu.Add(new ErdGrab(tempName, tempIndex));

                        break;
                    case 'u':
                    case 'U':

                        tempName = GrabEingabe(ref tempIndex);
                        neu.Add(new UrnenGrab(tempName, tempIndex));
                        break;
                    case 'x':
                        break;
                    case 'y':
                        break;
                    default:
                        WriteLine("\nThese are not the chars you are looking for");
                        grabWahl = 'y';
                        break;
                }

            } while (grabWahl != 'x');
            /// manuell erstellte Gräber ausgeben
            /// Liste sortieren
            neu.Sort((x,y) => x.Index.CompareTo(y.Index));
            foreach (var y in neu)
            {

                WriteLine($"{y.Name} auf Nummer {y.Index} in einem Typ {y.Typ}; zum Inschrift erstellen: ");
                y.MachInschrift();
                WriteLine("\n");
            }

            //WriteLine($"{a.Name} liegt auf Nummer {a.Index} in einem Typ {a.Typ}");


        }

        private static string GrabEingabe(ref int tempIndex)
        {
            string tempName;
            Write("\nName Verstorbener: ");
            tempName = ReadLine();
            Write("\nIndexnummer Grabstelle: ");
            /// string int Parse Exeption handling
            try
            {
                tempIndex = int.Parse(ReadLine());
            }
            catch (FormatException p)
            {
                WriteLine(p.Message);
            }

            return tempName;
        }
    }
}
