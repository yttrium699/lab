using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2
{
    public class Library: List<Book>
    {
        public void SortByPage()
        {
            this.Sort((x, y) => x.Page.CompareTo(y.Page));
        }
        public void PrintBooks()
        {
            foreach (var book in this) 
            {
 Console.WriteLine(book.ToString());               
            }
        }
    }
}
