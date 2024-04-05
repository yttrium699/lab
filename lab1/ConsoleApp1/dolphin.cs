using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class dolphin: animal, Imammal //также как с собачкой
    {
        public float height { get; set; }
        public float length { get; set; }
        public int age { get; set; } //возраст - полных лет
    }
}
