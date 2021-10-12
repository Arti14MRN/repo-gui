using System;
using System.IO;
namespace Lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("введите данные для сохранения в file.txt");
            var data = Console.ReadLine();
            File.WriteAllText("file.txt", data);
        }
    }
}
