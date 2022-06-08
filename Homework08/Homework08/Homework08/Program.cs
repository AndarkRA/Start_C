using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework08
{
    internal class Program
    {

        /// <summary>
        /// Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
        ///приложения(application-scope). Запросить у пользователя имя, возраст и род деятельности, а затем
        ///сохранить данные в настройках.При следующем запуске отобразить эти сведения.Задать
        ///приложению версию и описание.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string Greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{Greeting}!");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите свое имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.UserAge == 0) 
            {
                Console.Write("Введите возраст: ");
                Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                Properties.Settings.Default.Save();
            }


            if (string.IsNullOrEmpty(Properties.Settings.Default.UserOccupation))
            {
                Console.Write("Введите род занятий: ");
                Properties.Settings.Default.UserOccupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string userOccupation = Properties.Settings.Default.UserOccupation;

            Console.WriteLine($"Имя: {userName}\nВозраст: {userAge}\nРод деятельности: {userOccupation}");



            Console.ReadKey();
        }
    }
}
