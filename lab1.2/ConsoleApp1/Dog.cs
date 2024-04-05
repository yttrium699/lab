using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog: Animal, IMammal //класс собак наследующий от энимал и реализующий интерфейс тк явл млекопитающим
    {
        public float Height { get; set; }
        public string Breed { get; set; } //породу пишем, поэтому стринг
        public float WidthHeight { get; set; }
        public float WoolLength { get; set; }
    }
}
