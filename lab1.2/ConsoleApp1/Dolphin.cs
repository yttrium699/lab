using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dolphin: Animal, IMammal //также как с собачкой
    {
        public float Height { get; set; }
        public float Length { get; set; }
        public int Age { get; set; } //возраст - полных лет
    }
}
