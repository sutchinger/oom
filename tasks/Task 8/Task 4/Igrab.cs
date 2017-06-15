using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public interface IGrab
    {
        string Name { get; set; }
        int Index { get; set; }
        string Typ { get; }
        void MachInschrift();


    }
}
