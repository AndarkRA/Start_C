using System;

namespace Homework_02
{
    internal class Program
    {
        /// <summary>
        /// Запросить у пользователя минимальную и максимальную температуру за сутки и вывести
        /// среднесуточную температуру
        /// </summary>
        static void Task01()
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            double minTemp = double.Parse(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            double maxTemp = double.Parse(Console.ReadLine());

            double midTemp;
            midTemp = (minTemp + maxTemp) /2;

            Console.WriteLine($"Среднесуточная температура - {midTemp} градусов");

        }










        static void Main(string[] args)
        {
            Task01();
        }
    }
}
