using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tiger: Animal, IMammal //также как с собачкой
    {
        public float Height {  get; set; }
        public string Habitat { get; set; }
        public int Left { get; set; } //осталось в природе целых поэтому инт
    }
}
