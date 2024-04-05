using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Frog: Animal //тут наслеуемый класс без интерфейса, тк лягушка не млекопитающее
    {
        public string Color {  get; set; }
        public bool Poison { get; set; } //да или нет следовательно bool*
    }
}
