using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {


        /// <summary>
        /// Написать консольное приложение Task Manager, которое выводит на экран 
        /// запущенные процессы и позволяет завершить указанный процесс. 
        /// Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
        /// В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
        /// </summary>

        static void Main(string[] args)
        {

            Console.Write("Task manager");

            Process[] ProcessList = Process.GetProcesses();
            foreach (Process process in ProcessList)
            {
                Console.WriteLine($"{process.Id}, {process.ProcessName}");  
            }
            Console.WriteLine();

            Console.Write("Введите номер способа решения задачи: \n 1 -> по номеру id \n 2 -> по названию процесса ");
            int numberTask = int.Parse(Console.ReadLine());
            switch (numberTask)
            {
                case 1:
                    DoId();
                    break;
                case 2:
                    DoName();
                    break;
            }
        }

        /// <summary>
        /// Метод через id процесса
        /// </summary>
        static void DoId()
        {
            string id = GetId();
            try
            {
                using (Process process = Process.GetProcessById(Int32.Parse(id)))
                {
                    {
                        process.Kill();
                        Console.WriteLine($"Процесс с номером {id} звершен.");
                    }
                }
            }
            catch (IdException ex) when (ex.Code == ErrorCodes.empty)
            {
                Console.WriteLine("Вы не ввели номер id");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Данного номера {id} не существует");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка {ex.Message}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Метод через имя процесса(не доведен до ума)
        /// </summary>
        static void DoName()
        {
            string NameProcess = GetName();
            try
            {
                using (Process process = Process.GetProcessesByName(NameProcess)[0])
                {
                    process.Kill();
                    Console.WriteLine($"Процесс с навзванием {NameProcess} звершен.");
                }
            }
            catch (NameException ex) when (ex.Code == ErrorName.empty)
            {
                Console.WriteLine("Вы не ввели название процесса");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Данного названия {NameProcess} процесса не существует");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка {ex.Message}");
            }
            Console.ReadKey();
        }



        /// <summary>
        /// Метод для ввода id
        /// </summary>
        /// <returns></returns>
        /// <exception cref="IdException"></exception>
        static string GetId()
        {
            Console.WriteLine("Пожалуйста введите номер id из списка приведенного выше.");
            string id = Console.ReadLine();
            if (string.IsNullOrEmpty(id))
            {
                throw new IdException(ErrorCodes.empty);
            }
            return id;
        }

        /// <summary>
        /// метод для ввода имени
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NameException"></exception>
        static string  GetName()
        {
            Console.WriteLine("Пожалуйста введите имя из списка приведенного выше.");
            string NameProcess = Console.ReadLine();
            if (string.IsNullOrEmpty(NameProcess))
            {
                throw new NameException(ErrorName.empty);
            }
            return NameProcess;
        }
    }
}
