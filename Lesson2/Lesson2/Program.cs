using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Проект 1.Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            #region
            Console.Write("Введите Минимальную Температуру за сутки:");
            int mintemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Максимальную Температуру за сутки:");
            int maxtemp = Convert.ToInt32(Console.ReadLine());
            double diff = (mintemp + maxtemp);
            Console.WriteLine($"среднесуточная температура = {diff/2}");
            ///---------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Press anykey for continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            ///---------------------------------------------------------------------------------------------------------------------------
            ///Проект 2.Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            #region
            Console.Write("Введите порядковый номер текущего месяца:");
            int month = int.Parse(Console.ReadLine());
            string input = "Вы ввели ";
            switch (month)
            {
                case 1:
                    Console.WriteLine($"{input}Январь") ;
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
            ///---------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Press anykey for continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            ///---------------------------------------------------------------------------------------------------------------------------
            ///Проект 3.Определить, является ли введённое пользователем число чётным.
            #region
            Console.WriteLine("Введите число для проверки чётности");
            var even = int.Parse(Console.ReadLine());
            if (even % 2 == 0)
            {
                Console.WriteLine($"число {even} чётное" );
            }
            else
            {
                Console.WriteLine($"число {even} нечётное");
            }
            ///---------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Press anykey for continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            ///---------------------------------------------------------------------------------------------------------------------------
            ///Проект 4.Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
            #region
            Console.WriteLine("введите стоимость Кирпича");
            int PriceBrick = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество Кирпича");
            int PriceBrickCount = int.Parse(Console.ReadLine());


            Console.WriteLine("введите стоимость Цемент");
            int PriceCement = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество Цемента");
            int PriceCementCount = int.Parse(Console.ReadLine());

            Console.WriteLine("введите стоимость Щебеня кг");
            int PriceCrushedStone = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество Цемента");
            int PriceCrushedStoneCount = int.Parse(Console.ReadLine());

            int TotalPriceBrick = PriceBrick * PriceBrickCount;
            int TotalPriceCement = PriceCement * PriceCementCount;
            int TotalCrushedStoneCount = PriceCrushedStone * PriceCrushedStoneCount;

            int Summ = TotalPriceBrick + TotalPriceCement + TotalCrushedStoneCount;

            Console.WriteLine("----------------------");
            Console.WriteLine("|ООО СУПЕРЧЕК.ru     |");
            Console.WriteLine("|Чек № 4201          |");
            Console.WriteLine("|Кассир: Иванов      |");

            Console.WriteLine($"|1.Кирпич М150 x {PriceBrickCount}   |") ;
            Console.WriteLine($"|стоимость..........{TotalPriceBrick}|") ;

            Console.WriteLine($"|2.Цемент ПЦ-400 x {PriceCementCount} |");
            Console.WriteLine($"|стоимость..........{ TotalPriceCement }|") ;

            Console.WriteLine($"|3.Щебень Фракция x {PriceCrushedStoneCount}|");
            Console.WriteLine($"|стоимость..........{ TotalCrushedStoneCount }|");

            Console.WriteLine($"|всего..............{Summ}|" );
            Console.WriteLine("----------------------");
            #endregion
        }
    }
}
