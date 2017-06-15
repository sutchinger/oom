using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using Task_4.Gräber;

namespace Task_4
{
    class Wissenschaftler
    {

        public static void Run()
        {
            
            var Gegenmittel = Gegenmittelsuche();
            
        }

        public static Task<bool> GegenmittelTest(int x)
        {
            var random = new Random();
            var endRand = random.Next(10);
            return Task.Run(() =>
            {
                
                    Task.Delay(TimeSpan.FromSeconds(1.0)).Wait();
                    
                    if ((x%10) != endRand) return false;
                
                return true;
            });
        }

        public static async Task Gegenmittelsuche()
        {
            Task.Delay(TimeSpan.FromSeconds(5.0)).Wait();
            for (var i = 1; i < int.MaxValue; i++)
            {

                if (await GegenmittelTest(i))
                {
                    WriteLine($"\n\nGegenmittel gefunden nach: {i+5} Sekunden\n");
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
