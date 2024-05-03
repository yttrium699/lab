using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Compote<T> where T : Fruit //Обобщенный класс компот
    {
        private List<T> ingridients; //Список ингридиентов

        public Compote(List<T> ingridients) //Конструктор, принимает параметры-типы и заполняет список
        {
            this.ingridients = ingridients;
        }

        public void Recipe() //Вывод рецепта
        {
            Console.WriteLine("Recipe:");
            foreach (var ingridient in ingridients)
            {
                Console.WriteLine(ingridient);
            }
        }
    }
}
