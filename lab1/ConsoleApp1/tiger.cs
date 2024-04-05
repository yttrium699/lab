using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class tiger: animal, Imammal //также как с собачкой
    {
        public float height {  get; set; }
        public string habitat { get; set; }
        public int left { get; set; } //осталось в природе целых поэтому инт
    }
}
