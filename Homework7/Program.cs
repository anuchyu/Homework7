using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        //Просмотр записи.Функция должна содержать параметр ID записи, которую необходимо вывести на экран.
        //Создание записи.
        //Удаление записи.
        //Редактирование записи.
        //Загрузка записей в выбранном диапазоне дат.
        //Сортировка по возрастанию и убыванию даты.
        static void Main(string[] args)
        {
            string path = @"Guide.txt";
            Repository rep = new Repository(path);
            Console.WriteLine("Введите значение для выполнения операции:\n1 - Просмотр записи\n2 - Создание записи\n3 - Удаление записи\n4 - Редактирование записи/n5 -Загрузка записей в выбранном диапазоне дат/n6 - Сортировка дат по возрастанию/n7 - Сортировка дат по убыванию ");
            int var = Convert.ToInt32(Console.ReadLine());
            switch (var)
            {
                case 1:
                    {
                        PrintDbToConsole();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите данные сотрудника:");
                        Stuff ConcreteWorker = new Stuff(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                        Console.Write("Введите полное имя: ");
                        Console.Write("Введите возраст: ");
                        Console.Write("Введите рост: ");
                        Console.Write("Введите дату рождения: ");
                        Console.Write("Введите место рождения: ");
                        Add(ConcreteWorker);
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
