using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
            
        static void Start(char type,int time)
        {
            
            int currentTime = 0;

            if (type == 's')
            {
                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
            }
            else if (type == 'm') 
            {
                while (currentTime != (time * 60))
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
            }
            Console.Clear();   
            Console.WriteLine("Cronometro finalizado...");
            Thread.Sleep(1500);
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundos => 10s = segundos");
            Console.WriteLine("M = minutos => 1m = 1minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse (data.Substring((data.Length-1),1));
            Console.WriteLine (type);
            int time = int.Parse(data.Substring(0, data.Length - 1));
            Console.WriteLine(time);

            if (time == 0) 
            { 
                System.Environment.Exit(0);
            }

            Start(type, time);




        }
    }
}
