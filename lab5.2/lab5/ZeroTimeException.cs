using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class ZeroTimeException: Exception //Собственное исключение
    {
        public ZeroTimeException(string message): base(message) { }
    }
}
