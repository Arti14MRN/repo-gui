using System;

namespace Lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
            //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
            //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
            //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
            //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            Console.WriteLine("Номер месяца:");
            Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
        }
        enum season { error, 
            Winter,
            Spring, 
            Summer, 
            Autumn }
        static season OfMonth(int NumberOfMonth)
        {
            try
            {
                if (NumberOfMonth <= 0 || NumberOfMonth > 12)
                    throw new Exception("Ошибка: введите число от 1 до 12");
                switch ((NumberOfMonth % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.error;
            }
        }
        static string Season(season SwitchSeason)
        {
            switch (SwitchSeason)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
    }
}
