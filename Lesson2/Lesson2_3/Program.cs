using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Проект 3.Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите число для проверки чётности");
            var even = int.Parse(Console.ReadLine());
            if (even % 2 == 0)
            {
                Console.WriteLine($"число {even} чётное");
            }
            else
            {
                Console.WriteLine($"число {even} нечётное");
            }
        }
    }
}
