using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Gräber
{
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
        public ErdGrab(int newIndex)
        {
            Index = newIndex;
        }


        public int Index { get; set; }
        public string Name { get; set; }

        public string Typ => "Erdgrab";
        public void MachInschrift()
        {
            Console.WriteLine("Steinmetz wird beauftragt");
        }
    }
}
