using System;

namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}! Сегодня {DateTime.Now}.");
        }
    }
}
