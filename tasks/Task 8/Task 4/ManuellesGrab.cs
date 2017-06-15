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
    class ManuellesGrab
    {
        public static void Run()
        {

            /// Manuelle Grab Vergabe
            char grabWahl = 'y';
            var neu = new List<IGrab>();

            string tempName;
            int tempIndex = 0;

            do
            {

                WriteLine("\nNeues Grab vergeben:\nE: ErdGrab\nP: Pyramide\nU: Urnengrab\nx: beenden");
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

                        tempName = GrabEingabe.Eingabe(ref tempIndex);
                        neu.Add(new Pyramide(tempName, tempIndex));
                        break;
                    case 'e':
                    case 'E':
                        tempName = GrabEingabe.Eingabe(ref tempIndex);

                        neu.Add(new ErdGrab(tempName, tempIndex));

                        break;
                    case 'u':
                    case 'U':

                        tempName = GrabEingabe.Eingabe(ref tempIndex);
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
            neu.Sort((x, y) => x.Index.CompareTo(y.Index));
            foreach (var y in neu)
            {

                WriteLine($"{y.Name} auf Nummer {y.Index} in einem Typ {y.Typ}; zum Inschrift erstellen: ");
                y.MachInschrift();
                WriteLine("\n");
            }

        }
    }
}
