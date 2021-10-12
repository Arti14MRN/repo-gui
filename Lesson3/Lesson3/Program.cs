using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Написать программу, выводящую элементы двухмерного массива по диагонали.
            //
            //Random rand = new Random();
            var array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.Write("числа по диагнонали:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    //array[i, j] = rand.Next(1, 9);
                    if (i == j)
                    {
                        Console.Write(array[i, j]);
                    }
                    //Console.Write("{0,3}", array[i, j]);
                }

            }
            Console.WriteLine();

            //2.Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
            //
            var ArrayList = new string[5, 2] { { "Петя", "88005551111" }, { "Дима", "88005551112" }, { "Артем", "88005551113" }, { "Вика", "88005551114" }, { "Настя", "88005551115" } };

            for (int i = 0; i < ArrayList.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayList.GetLength(1); j++)
                {
                    Console.Write($"{ArrayList[i, j]}");
                }
                Console.WriteLine();
            }

            // 3.Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
            //
            var hi = Console.ReadLine();
            hi.ToCharArray();
            for (int i = hi.Length - 1; i >= 0; i--)
            {
                Console.Write(hi[i]);
            }

            //4 * «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            //
            var Ships = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < Ships.GetLength(0); i++)
            {
                for (int j = 0; j < Ships.GetLength(1); j++)
                {
                    Ships[i, j] = rand.Next(0, 2);

                    if (Ships[i, j] == 0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
            }
        }
        
    }
}

