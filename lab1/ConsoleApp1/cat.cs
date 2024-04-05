using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class cat: animal, Imammal //также как и с собаками, только кот
    {
        public float height {  get; set; }
        public string breed { get; set; }
        public string furColor { get; set; }
    }
}
