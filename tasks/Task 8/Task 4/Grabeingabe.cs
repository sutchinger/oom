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
    public class GrabEingabe
    {
        public static string Eingabe(ref int tempIndex)
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
