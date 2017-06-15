using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Gräber
{
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
        public UrnenGrab(int newIndex)
        {
            Index = newIndex;
        }


        public int Index { get; set; }
        public string Name { get; set; }

        public string Typ => "Urnengrab";
        public void MachInschrift()
        {
            Console.WriteLine("Ettikettiermaschine wird aus dem Keller geholt");
        }


    }
}
