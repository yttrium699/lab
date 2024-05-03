using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Fruit //Базовый класс для фруктов
    {
        public int Amount { get; set; } //Свойство количество

        public Fruit(int amount) //Конструктор с параметром для установки количества
        {
            Amount = amount;
        }

        public override string ToString() //Переопределение метода
        {
            return $"Fruit: {GetType().Name}, Amount: {Amount}";
        }
    }
}
