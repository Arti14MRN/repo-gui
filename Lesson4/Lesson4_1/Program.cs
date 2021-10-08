using System;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод GetFullName(string firstName, string lastName, string patronymic),
            //принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
            //Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            GetFullName("Ангархаев", "Виталий", "Витальевич");
            GetFullName("Новиков", "Павел", "Дмитриевич");
            GetFullName("Ягодинский", "Александр", "Яковлевич");
            GetFullName("Тертюк", "Инна", "Геннадьевна");

        }

        static void GetFullName(string FirstName, string LastName, string patronymic)
        {
            Console.WriteLine($"{FirstName} {LastName} {patronymic} ");
        }
    }
}
