using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {

        static void Menu()
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1 - Novo Contador");
            Console.WriteLine("2 - Sair");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    {
                        Console.WriteLine("Definir tempo do contador:");
                        int set = int.Parse(Console.ReadLine());
                        Start(set);
                        break;
                    }
                case 2:
                    Console.Clear();
                    System.Environment.Exit(0); break;
            }
        }


        static void Start(int set)
        {
            int time = set;

            while (time > 0)
            {
                time--;
                Console.Clear();
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Contador Finalizado!");
            Thread.Sleep(3000);
            Console.Clear();
            Menu();

        }
        private static void Main(string[] args)
        {
            Menu();
        }
    }
}
