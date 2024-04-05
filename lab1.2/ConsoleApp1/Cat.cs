using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat: Animal, IMammal //также как и с собаками, только кот
    {
        public float Height {  get; set; }
        public string Breed { get; set; }
        public string BurColor { get; set; }
    }
}
