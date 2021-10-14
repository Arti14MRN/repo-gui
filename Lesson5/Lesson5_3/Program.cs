using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            var InputBinNum = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var array = new byte[InputBinNum.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (!byte.TryParse(InputBinNum[i], out var number))
                {
                    Console.WriteLine($"Неверные входные данные {InputBinNum[i]}");
                    return;
                }
                array[i] = number;
            }
            ///Записываем в бинарный файл
            using (var bw = new BinaryWriter(File.OpenWrite("binaryNumbers.bin"))) 
            {
                bw.Write(array);
                bw.Flush();
            }
            ///Читаем из Бинарного Файла для проверки
            byte[] newData;
            using (var br = new BinaryReader(File.OpenRead("binaryNumbers.bin")))
            {
                newData = br.ReadBytes(array.Length);
            }

            for (var i = 0; i < newData.Length; i++)
            {
                Console.Write(newData[i] + " ");
            }
        }
    }
}
