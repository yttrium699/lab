using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class frog: animal //тут наслеуемый класс без интерфейса, тк лягушка не млекопитающее
    {
        public string color {  get; set; }
        public int poison { get; set; } //да или нет следовательно int
    }
}
