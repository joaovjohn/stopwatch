using System;
using System.Threading;

namespace Stopwatch
{
    class Program 
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Start(int tempo)
        {
            int currentTime = 0;

            while(currentTime != tempo)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("s = Segundos (10s)");
            Console.WriteLine("m = Minutos (10m)");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicacao = 1;
            
            if (type == 'm')
                multiplicacao = 60;
            
            if (time ==0)
                System.Environment.Exit(0);
                
            PreStart(time * multiplicacao);


            Console.WriteLine(data);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(time);
        }
    }
}