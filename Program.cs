// *****************************************************************
// Классная работа                                                 *
// Выполнил: Матченко М.С., группа 2-ИСП-оКФ                       *
// *****************************************************************
using System;
using System.Text;
namespace KL_R
{
    // Cтруктура Гостиница
    public struct Hotel
    {
        // Поля структуры
        public string name; // Название гостиницы
        public int roomCount; // Количество комнат
        public string category; // Категория
        public double price; // Стоимость
        // Конструктор, который инициализирует все поля
        public Hotel(string _name, int _roomCount, string _category, double _price)
        {
            name = _name;
            roomCount = _roomCount;
            category = _category;
            price = _price;
        }
        // Метод для вывода данных структуры на экран
        public void PrintInfo() // Вывод информации о структуре
        {
            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Название гостиницы:  {name}");
            Console.WriteLine($"Количество комнат:   {roomCount}");
            Console.WriteLine($"Категория:           {category}");
            Console.WriteLine($"Стоимость:           {price} RUB");
            Console.WriteLine(new string('-', 35));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Классная работа";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Домашнее задание № 1.";
            Console.Clear();
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("--- Ввод данных о гостиницах ---\n");
            // Ввод данных для 1 гостиницы
            Console.WriteLine("Введите данные для первой гостиницы:");
            Console.Write("Название:");
            string name1 = Console.ReadLine();
            Console.Write("Количество комнат:");
            int roomCount1 = int.Parse(Console.ReadLine());
            Console.Write("Категория:");
            string category1 = Console.ReadLine();
            Console.Write("Цена за сутки:");
            double price1 = double.Parse(Console.ReadLine());
            // Создание первой переменной через конструктор
            Hotel hotel1 = new Hotel(name1, roomCount1, category1, price1);
            Console.WriteLine(); // Пустая строка для разделения
            // Ввод данных для 2 гостиницы
            Console.WriteLine("Введите данные для второй гостиницы:");
            Console.Write("Название:");
            string name2 = Console.ReadLine();
            Console.Write("Количество комнат:");
            int roomCount2 = int.Parse(Console.ReadLine());
            Console.Write("Категория:");
            string category2 = Console.ReadLine();
            Console.Write("Цена за сутки:");
            double price2 = double.Parse(Console.ReadLine());
            // Создание второй переменной через конструктор
            Hotel hotel2 = new Hotel(name2, roomCount2, category2, price2);
            Console.WriteLine();
            // Вывод информации о двух созданных переменных на экран
            Console.WriteLine("--- Итоговая информация ---");
            Console.WriteLine("  --- Первая гостиница ---");
            hotel1.PrintInfo();
            Console.WriteLine("  --- Вторая гостиница ---");
            hotel2.PrintInfo();
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
