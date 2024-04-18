using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add(new Book("Война и мир", "Лев Толстой", 1225));
            library.Add(new Book("Узорный покров", "Сомерсет Моэм", 349));
            library.Add(new Book("Искусство завоевывать друзей", "Дейл Карнеги", 278));
            library.Add(new Book("Блеск и нищета куртизанок", "Оноре де Бальзак", 526));
            library.Add(new Book("Любовник леди Чаттерли", "Дэвид Лоуренс", 890));
            library.SortByPage();

            Console.WriteLine("Список книг:");
            library.PrintBooks();


        }
    }
}
