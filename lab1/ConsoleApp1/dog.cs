using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class dog: animal, Imammal //класс собак наследующий от энимал и реализующий интерфейс тк явл млекопитающим
    {
        public float height { get; set; }
        public string breed { get; set; } //породу пишем, поэтому стринг
        public float widthHeight { get; set; }
        public float woolLength { get; set; }
    }
}
