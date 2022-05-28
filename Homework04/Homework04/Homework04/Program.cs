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

        /// <summary>
        /// Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        ///возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести
        ///результат на экран.
        /// </summary>
        /// 

        static void HW04Task02()
        {
            int sum1 = Sum();
            Console.WriteLine(sum1);

        }
        static int Sum()
        {

            Console.WriteLine("Введите несколько чисел, разделенных пробелом, пример:\n123 321 55555");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');
            int[] numbers = new int[words.Length];
            int Sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int tmp;
                if (int.TryParse(words[i], out tmp))
                {
                    numbers[i] = tmp;
                    Sum += numbers[i];
                }

                else
                {
                    Console.WriteLine("Введенные значения не подходят");

                }
            }
            return Sum;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Домашнее задание к уроку 4");
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
                    HW04Task01();
                    break;
                case 2:
                    HW04Task02();
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
                    HW04Task02();

            }
        }
    }
}
