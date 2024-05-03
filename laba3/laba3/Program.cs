using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Apple> apples = new List<Apple>()
            {
                new Apple(3),
                new Apple(4),
            };

            Compote<Apple> appleCompote = new Compote<Apple>(apples);

            appleCompote.Recipe();

            List<Plum> plums = new List<Plum>()
            {
                new Plum(5),
                new Plum(6),
            };

            Compote<Plum> plumCompote = new Compote<Plum>(plums);
        
            plumCompote.Recipe();
        }

    }
}
