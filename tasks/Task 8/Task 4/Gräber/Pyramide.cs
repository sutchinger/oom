using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Gräber
{
    class Pyramide : IGrab
    {
        public Pyramide(string newName, int newIndex)
        {
            Name = newName;
            {
                if (Name == "")
                {
                    Name = "Mumie X";
                }
            }
            Index = newIndex;
            {
                Index = Index > 0 ? Index : 1;

            }
        }

        public Pyramide(int newIndex)
        {
            Index = newIndex;
        }
        public Pyramide() { }

        public string Name { get; set; }
        public int Index { get; set; }
        public string Typ => "Pyramide";
        public void MachInschrift()
        {
            Console.WriteLine("Sklavenarmee wird herangetrieben");
        }



    }
}
