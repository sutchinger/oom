﻿using static System.Console;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using Task_4.Gräber;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{


    class Program
    {

        static void Main(string[] args)
        {
            var rand = new Random();
            var pCount = 0;
            var eCount = 1000;
            var uCount = 1000000;
            GrabArrayErstellen.Run();
            ManuellesGrab.Run();


            WriteLine("*****************************\n");
            WriteLine("UNERWARTETER PEST AUSBRUCH!!!\n");
            WriteLine("*****************************\n");
            var pSource = new Subject<Pyramide>();
            var eSource = new Subject<ErdGrab>();
            var uSource = new Subject<UrnenGrab>();

            pSource
                .Subscribe(x =>
                {
                    WriteLine($"Index: {x.Index}");
                    x.MachInschrift();
                    WriteLine();
                })
                ;
                
           

            eSource
                .Subscribe(x =>
                {
                    WriteLine($"Index: {x.Index}");
                    x.MachInschrift();
                    WriteLine();
                })
                ;

            uSource
                .Subscribe(x =>
                {
                    WriteLine($"Index: {x.Index}");
                    x.MachInschrift();
                    WriteLine();
                })
                ;

            var pTask = Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(TimeSpan.FromSeconds(5.0 + rand.Next(5))).Wait();
                    pCount++;
                    Console.WriteLine("*******ANOTHER KING GONE******");
                    Pyramide x = new Pyramide(pCount);
                    pSource.OnNext(x);
                    //return x;
                }
            });
            var eTask = Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(TimeSpan.FromSeconds(2.0 + rand.Next(4))).Wait();
                    eCount++;
                    Console.WriteLine("R.I.P");
                    ErdGrab e = new ErdGrab(eCount);
                    eSource.OnNext(e);
                    //return x;
                }
            });
            var uTask = Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(TimeSpan.FromSeconds(1.0 + rand.Next(1))).Wait();
                    uCount++;
                    Console.WriteLine("some scum got burnt");
                    UrnenGrab x = new UrnenGrab(uCount);
                    uSource.OnNext(x);
                    //return x;
                }
            });

            Wissenschaftler.Run();



            //WriteLine("Anykey");
            ReadKey();

    
        }

       
    }
}
