using System;

namespace Homework04
{
    internal class Program
    {

        /// <summary>
        /// Написать метод GetFullName(string firstName, string lastName, string
        ///patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
        ///объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль
        ///3–4 разных ФИО.
        /// </summary>

        // static void GetFullName(string firstName, string lastName, string patronymic)


        static void HW04Task01()
        {
            Console.WriteLine(GetFullName("Иван", "Иванов", "Иванович"));
            Console.WriteLine(GetFullName("Петр", "Романов", "Николаевич"));
            Console.WriteLine(GetFullName("Екатерина", "Юдина", "Борисовна"));

        }
        static string GetFullName (string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }


        static void Main(string[] args)
        {



            Console.WriteLine("Домашнее задание к уроку 4");
            Console.WriteLine("======================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");
            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    HW04Task01();
                    break;

                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Некорректный номер задачи, \nПовторите попытку ввода... ");
                    Console.ReadKey();
                    break;
                    HW04Task01();

            }
        }
    }
}
