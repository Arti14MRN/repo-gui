using System;
using System.IO;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            using var sw = File.AppendText("startup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss tt");
            sw.WriteLine(time);
        }
    }
}
