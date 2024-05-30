using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class DivideCommand: ICommand
    {
        private double _a;
        private double _b; 
        private double _result;

        public DivideCommand (double a, double b)
        {
            _a = a;
            _b = b;
        }

        public void Execute ()
        {
            if (_b == 0)
            {
                Console.WriteLine("Делить на 0 нельзя!");
                return;
            }
            _result = _a / _b;
            Console.WriteLine($"Результат деления: {_result}");
        }

        public void Undo ()
        {
            Console.WriteLine($"Отмена деления: {_result}*{_b} = {_result * _b}");
        }
    }
}
