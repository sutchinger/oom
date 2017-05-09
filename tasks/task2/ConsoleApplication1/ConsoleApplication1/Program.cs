using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class Grab
    {
        private string name;
        private int index;

        public Grab(string newName, int newIndex)
        {
            if (newName == null)
            {
                throw new ArgumentException("kein Name");
            }
            if (newIndex < 1)
            {
                throw new ArgumentException("Indexnummer ungueltig");
            }

            name = newName;
            index = newIndex;
        }
        public Grab(int newIndex) : this("John Doe", newIndex)
        {
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Indexnummer ungueltig");
                }
                index = value;
            }
        }
        public string Name => name;



    }
    class Program
    {
        static void Main(string[] args)
        {
            Grab a = new Grab("Mayer", 1234);

            Console.WriteLine($"Grab Name ={a.Name} auf Lageplatz {a.Index}");
        }
    }
}
