using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.Title = Properties.Settings.Default.ApplicationName;     

            string choice = Greeting();
            Info(choice);
            newInfo();
                                 
            Console.ReadKey(true);
        }

        /// <summary>
        /// Вывод приветствия и запрос на вывод информации
        /// </summary>
        /// <returns></returns>
        static string Greeting ()
        { 
            Console.WriteLine(Properties.Settings.Default.Greeting);
            Console.WriteLine("\nВывести информацию предыдущих введенных данных?" +
                              "\n 0 - нет" +
                              "\n 1 - да");
             return Console.ReadLine();
        }

        /// <summary>
        /// Вывод предыдущей информации
        /// </summary>
        /// <param name="choice"></param>
        static void Info(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine($"Имя: {Properties.Settings.Default.userName}");
                Console.WriteLine($"Возраст: {Properties.Settings.Default.userAge}");
                Console.WriteLine($"Вид деятельности: {Properties.Settings.Default.userCareer}");
            }

            Console.ReadKey(true);
            Console.Clear();

        }

        /// <summary>
        /// Ввод новой информации и сохранение
        /// </summary>
        static void newInfo()
        {
            Console.WriteLine("\nВведите данные:");
            Console.Write("Имя: ");
            Properties.Settings.Default.userName = Console.ReadLine();
            Console.Write("Возраст: ");
            Properties.Settings.Default.userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вид деятельности: ");
            Properties.Settings.Default.userCareer = Console.ReadLine();
            Properties.Settings.Default.Save();
        }
    }
}
