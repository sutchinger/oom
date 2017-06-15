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
        public static int count { get; set; }
        public static void Run()
        {
            
            var Gegenmittel = Gegenmittelsuche();
            
        }

        public static Task<bool> GegenmittelTest(int x)
        {
            var random = new Random();
            var endRand = random.Next(20);
            return Task.Run(() =>
            {
                
                Task.Delay(TimeSpan.FromSeconds(1.0)).Wait();
                
                if ((x%20) != endRand) return false;
                
                return true;
            });
        }

        public static async Task Gegenmittelsuche()
        {
            //Task.Delay(TimeSpan.FromSeconds(5.0)).Wait();
            for (var i = 1; i < int.MaxValue; i++)
            {
                await WissenschaftlerLebt();
                if (await GegenmittelTest(i))
                {
                    WriteLine($"\n\nGegenmittel gefunden nach: {i+5} Sekunden\n");
                    WriteLine($"{count} Wissenschaftler und unzählige andere mussten ihre Leben lassen.\n");
                    System.Environment.Exit(1);
                }
            }
        }
        public static async Task<bool> WerLebt()
        {
            
            var rand = new Random();
            var die = rand.Next(3000);
            await Task.Delay(TimeSpan.FromMilliseconds(die));
            if (die < 2500) return true;
            return false;
        }
            
        
        public static async Task WissenschaftlerLebt()
        {
            
            if (!await WerLebt())
            {
                count++;
                Console.WriteLine($"\n{count} brave scientist(s) passed away!\n");
            }

        }
    }
}
