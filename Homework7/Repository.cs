using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    struct Repository
    {
        private Stuff[] stuff; // Массив для хранения данных
        private string path;  // Путь к файлу
        int index; // Текущий элемент для добавления в stuff
        string[] titles; // Массив хранит заголовки полей
        public Repository( string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[0];
            this.stuff = new Stuff[1];
            this.Load(); // Загрузка данных
        }
        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag"></param> Условия увеличения
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.stuff, this.stuff.Length + 2);
            }
        }
        /// <summary>
        /// Метод добавления сотрудника в хранилище
        /// </summary>
        /// <param name="ConcreteWorker">Сотрудник</param>
        public void Add(Stuff ConcreteWorker)
        {
            this.Resize(index >= this.stuff.Length);
            this.stuff[index] = ConcreteWorker;
            this.index++;
        }
        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        private void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                titles = sr.ReadLine().Split('#');
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    Add(new Stuff(args[0], Convert.ToInt32(args[1]), Convert.ToInt32(args[2]), args[3], args[4]));
                }
            }
        }
        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="Path"></param>
        public void Save (string Path)
        {
            string temp = String.Format($"{0},{1},{2},{3},{4},{5},{6}",
                this.stuff[0].ID, this.stuff[1].time, this.stuff[2].FullName, this.stuff[3].Age,
                this.stuff[4].Height, this.stuff[5].BornData, this.stuff[6].BornFrom);
            File.AppendAllText(Path, $"{temp}\n");
        }
        /// <summary>
        /// Вывод данных в консоль
        /// </summary>
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0],15}{this.titles[1],15}{this.titles[2],15}{this.titles[3],15}{this.titles[4],15}{this.titles[5],15}{this.titles[6],15}");
            for (int i = 0; i< index; i++)
            {
                Console.WriteLine(this.stuff[i].Print());
            }
        }
        /// <summary>
        /// Количество сотрудников в хранилище
        /// </summary>
        public int Count { get { return this.index; } }
        }
        
    }
}
