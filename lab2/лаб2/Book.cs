using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }

        public Book(string title, string author, int page)
        {
            Title = title;
            Author = author;
            Page = page;
        }
        public override string ToString() 
        {
            return $"Автор: {Author}, Название: {Title}";
        }
    }       
}
