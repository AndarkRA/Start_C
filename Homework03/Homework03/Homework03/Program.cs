﻿using System;

namespace Homework03
{
    internal class Program
    {
        /// <summary>
        /// Написать программу, выводящую элементы двумерного массива по диагонали.
        /// </summary>
        static void HW03Task01()
        {

            int next_string = 0;
            int[,] array01 = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < array01.GetLength(0); i++)
            {
                for (int j = 0; j < array01.GetLength(1); j++)
                {
                    array01[i, j] = next_string + 1;
                    Console.WriteLine($"{new string(' ', next_string)}{array01[i, j]}");
                    next_string++;
                }
                Console.ReadKey();
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание к уроку 3");
            Console.WriteLine("======================");
            Console.WriteLine("1 -> Задача 1");
            Console.WriteLine("0 -> Заврешение работы приложения");
            Console.WriteLine("======================");

            Console.Write("Введите номер задачи ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    HW03Task01();
                    break;


                case 0:
                    Console.WriteLine("Завершение работы приложения ...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Некорректный номер задачи, \nПовторите попытку ввода... ");
                    Console.ReadKey();
                    break;
                    HW03Task01();

            }
        }
    }
}
