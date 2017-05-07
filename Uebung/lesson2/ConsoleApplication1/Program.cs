using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {

            int a = 5;
            string hello = "Hello World!";
            double x = 123.456;
            bool b = true;
            string hello = "Hello World!";
            //Console.BackgroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}\n", hello);


            // strings and other values can be concatenated using `+`.
            Console.WriteLine("The value of x*a is " + (x * a) + ", and b is " + b + ".");

            // ... or you can use place holders ...
            Console.WriteLine("The value of x*a is {0}, and b is {1}.", x * a, b);

            // ... or string interpolation
            Console.WriteLine($"The value of x*a is {x * a}, and b is {b}.");

            int[] xs = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int firstElement = xs[0];
            xs[9] = 100;


            var list1 = new List<string> { "This", "is", "a", "list", "of", "strings", "!" };
            var list2 = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            list1.Add("Hello World.");
            list2.Add(100);



            return 0;
        }
    }
}
