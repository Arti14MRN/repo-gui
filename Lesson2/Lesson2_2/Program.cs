using System;

namespace Lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Проект 2.Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.Write("Введите порядковый номер текущего месяца:");
            int month = int.Parse(Console.ReadLine());
            string input = "Вы ввели ";
            switch (month)
            {
                case 1:
                    Console.WriteLine($"{input}Январь");
                    break;
                case 2:
                    Console.WriteLine($"{input}Февраль");
                    break;
                case 3:
                    Console.WriteLine($"{input}Март");
                    break;
                case 4:
                    Console.WriteLine($"{input}Апрель");
                    break;
                case 5:
                    Console.WriteLine($"{input}Май");
                    break;
                case 6:
                    Console.WriteLine($"{input}Июнь");
                    break;
                case 7:
                    Console.WriteLine($"{input}Июль");
                    break;
                case 8:
                    Console.WriteLine($"{input}Август");
                    break;
                case 9:
                    Console.WriteLine($"{input}Сентябрь");
                    break;
                case 10:
                    Console.WriteLine($"{input}Октябрь");
                    break;
                case 11:
                    Console.WriteLine($"{input}Ноябрь");
                    break;
                case 12:
                    Console.WriteLine($"{input}Декабрь");
                    break;
            }
        }
    }
}
