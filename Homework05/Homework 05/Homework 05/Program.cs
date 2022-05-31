using System;
using System.IO;

namespace Homework_05
{
    internal class Program
    {
        /// <summary>
        /// Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл
        /// </summary>
        static void HW05Task01()
        {
            Console.WriteLine("Введите что угодно: ");
            string filename = "task01.txt";
            File.WriteAllText(filename, Console.ReadLine());
        }


        /// <summary>
        /// Написать программу, которая при старте дописывает текущее время в файл
        /// «startup.txt».
        /// </summary>

        static void HW05Task02()
        {
            File.AppendAllText("startup.txt", Environment.NewLine + DateTime.Now.ToString());
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание к уроку 5");
            Console.WriteLine("======================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("2 -> Задача 2");
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");
            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    HW05Task01();
                    break;
                case 2:
                    HW05Task02();
                    break;


                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Некорректный номер задачи, \nПовторите попытку ввода... ");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
