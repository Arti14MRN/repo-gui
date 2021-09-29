using System;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Проект 1.Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            
            Console.Write("Введите Минимальную Температуру за сутки:");
            int mintemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Максимальную Температуру за сутки:");
            int maxtemp = Convert.ToInt32(Console.ReadLine());
            double diff = (mintemp + maxtemp);
            Console.WriteLine($"среднесуточная температура = {diff / 2}");
        }
    }
}
