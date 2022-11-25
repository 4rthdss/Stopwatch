using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (time >= currentTime)
            {
                Console.Clear();
                Console.WriteLine(time);
                time--;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Time over.");
            Thread.Sleep(2500);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Stopwatch");
            Console.WriteLine("Seconds => 40s = 40 seconds");
            Console.WriteLine("Minutes => 4m = 240 seconds");
            Console.WriteLine("Exit => 0s or 0m");
            Console.WriteLine("How long do u want to count?");

            string userInput = Console.ReadLine().ToLower();
            char timeUnit = char.Parse(userInput.Substring(userInput.Length - 1, 1));
            int time = int.Parse(userInput.Substring(0, userInput.Length - 1));

            if (time == 0)
            {
                Environment.Exit(0);
            }
            else if (timeUnit == 's')
            {
                // seconds
                Start(time);
                Thread.Sleep(1000);
                Menu();
            }
            else if (timeUnit == 'm')
            {
                // minutes
                time *= 60;
                Start(time);
                Thread.Sleep(1000);
                Menu();
            }
            else
            {
                Menu();
            }
        }
    }
}