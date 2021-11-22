using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Stuff
    {
        private static int counter;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="ID"></param>ID
        /// <param name="Datanow"></param>Дата и время добавления записи
        /// <param name="FullName"></param>Ф.И.О.
        /// <param name="Age"></param>Возраст
        /// <param name="Height"></param>Рост
        /// <param name="BornData"></param>Дата рождения
        /// <param name="BornFrom"></param>Место рождения
        public Stuff ( string FullName, int Age, int Height, string BornData, string BornFrom )
        {
            ID = ++counter;
            this.FullName = FullName;
            this.Age = Age;
            this.Height = Height;
            this.BornData = BornData;
            this.BornFrom = BornFrom;
        }

        public DateTime time = DateTime.Now;

        /// <summary>
        /// Методы
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.ID,15}{this.time,15}{this.FullName,15}{this.Age,15}{this.Height,15}{this.BornData,15}{this.BornFrom,15}";
        }
        /// <summary>
        /// Свойства
        /// </summary>
        public int ID { get; private set;}
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string BornData { get; set; }
        public string BornFrom { get; set; }

    }
}
