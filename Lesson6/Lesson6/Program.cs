using System;
using System.Diagnostics;
using System.Linq;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
            ///Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
            ///В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

            var ProcessList = Process.GetProcesses();
            foreach (var process in ProcessList)
            {
                Console.WriteLine($"{process.Id} {process.ProcessName}");
            }
            Console.WriteLine("----------------------------------------");
            Console.Write("Введите ID или Name процесса = ");
            var name = Console.ReadLine();
            int num;
            bool isNumber = int.TryParse(name, out num);
            if (isNumber)
            {
                Console.WriteLine("isNumber");
                KillerID(num);

            }
            else
            {
                Console.WriteLine("isName");
                Killer(name);
            }
            //убить по Name
            static void Killer(string name)
            {
                try
                {
                    var ProcessList = Process.GetProcesses();
                    ProcessList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Process {name} not found!");
                }
            }
            //убить по ID
            static void KillerID(int num)
            {
                try
                {
                    Process.GetProcessById(num).Kill(true);
                    Console.WriteLine($"{num} deleted!");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"{num} is terminated");
                }
            }
        }
    }
}
