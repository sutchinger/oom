using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE2
{
    class Book
    {
        private string title;
        private decimal price;

        public Book(string newTitle, decimal newPrice)
        {
            
            if (newTitle == null)
                throw new ArgumentException("nix");
            title = newTitle;
            Price = newPrice;
        }
        public Book(string newTitle) : this(newTitle, 0) // ein Constructor mit anderem Constructor aufrufen
        {
        }
        public Book() : this("default", 0) { }

        //public string getTitle() =>  title; //eigentlich { return title;}
        /*public decimal getPrice() => price; 
        public void setPrice(decimal newPrice)
        {
            if (newPrice < 0)
                throw new ArgumentException("negativer Preis");
            price = newPrice;
        }
        */
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("negativer Preis");
                price = value;  // value = keyword für Zuweisung
            }
        }
        /*
         * public string Title     //geht auch nur get
        {
            get
            {
                return title;
            }
        }
        */
        public string Title => title; // gleiches wie oben, = "getter" property

    }

    class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("Mein erstes Buch", 10);
            Book c = a; // gleiche Referenz, keine Kopie

            Book b = new Book("ABC"); //Überladen von Funktionen
            Book d = new Book();






            /*
            a.price = -10; // wenn public sichtbar, sonst syntaxfehler
            Console.WriteLine("Buchpreis " + a.price);
            */
            Console.WriteLine($"Buchpreis {a.Price} Name {a.Title} ");  // $ zum Einsetzen



        }
    }
}
