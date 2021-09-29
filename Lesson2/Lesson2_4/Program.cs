using System;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Проект 4.Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
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

            Console.WriteLine($"|1.Кирпич М150 x {PriceBrickCount}   |");
            Console.WriteLine($"|стоимость..........{TotalPriceBrick}|");

            Console.WriteLine($"|2.Цемент ПЦ-400 x {PriceCementCount} |");
            Console.WriteLine($"|стоимость..........{ TotalPriceCement }|");

            Console.WriteLine($"|3.Щебень Фракция x {PriceCrushedStoneCount}|");
            Console.WriteLine($"|стоимость..........{ TotalCrushedStoneCount }|");

            Console.WriteLine($"|всего..............{Summ}|");
            Console.WriteLine("----------------------");
        }
    }
}
