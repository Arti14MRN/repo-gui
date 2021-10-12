using System;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
            //и возвращающую число — сумму всех чисел в строке.
            //Ввести данные с клавиатуры и вывести результат на экран.
            int sum = 0;
            Console.Write("введите числа через пробел:");
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine($"сумма чисел равна:{sum}");
        }
    }
}
