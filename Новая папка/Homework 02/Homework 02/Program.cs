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
            midTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Среднесуточная температура - {midTemp} градусов");

        }

        /// <summary>
        /// Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        /// </summary>
        static void Task02()

        {
            Console.Write("Введите номер месяца: ");
            int numberMonth = int.Parse(Console.ReadLine());
            string Month = "";
            switch (numberMonth)
            {
                case 1: Month = "Январь";
                    break;
                case 2: Month = "Февраль";
                    break ;
                case 3:
                    Month = "Март";
                    break;
                case 4:
                    Month = "Апрель";
                    break;
                case 5:
                    Month = "Май";
                    break;
                case 6:
                    Month = "Июнь";
                    break;
                case 7:
                    Month = "Июль";
                    break;
                case 8:
                    Month = "Август";
                    break;
                case 9:
                    Month = "Сентябрь";
                    break;
                case 10:
                    Month = "Октябрь";
                    break;
                case 11:
                    Month = "Ноябрь";
                    break;
                case 12:
                    Month = "Декабрь";
                    break;
                    default:
                    Console.WriteLine("Укажите номер месяца от 1 до 12");
                    break;

            }
            Console.WriteLine(Month);

        }

        /// <summary>
        /// Определить, является ли введённое пользователем число чётным.
        /// </summary>
        static void Task03()
        {
            Console.Write("Введите ваше число: ");
            int yourNumber = int.Parse(Console.ReadLine());

            if (yourNumber % 2 == 0)
            {
                Console.WriteLine($"{yourNumber} - четное число");
            }
            else 
            {
                Console.WriteLine($"{yourNumber} - нечетное число");
            }

        }











        static void Main(string[] args)
        {

            Console.WriteLine("Домашнее задание к уроку 2");
            Console.WriteLine("======================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("2 -> Задача 2");
            Console.WriteLine("3 -> Задача 3");
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");

            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());

            switch (numberTask)
            {
                case 1:
                    Task01();
                    break;

                case 2:
                    Task02();
                    break;
                case 3:
                    Task03();
                    break;




                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Некорректный номер задачи, \nПовторите попытку ввода... ");
                    Console.ReadKey();
                    break;


                    Task01();
                    Task02();
                    Task03();

            }
        }
    }
}
