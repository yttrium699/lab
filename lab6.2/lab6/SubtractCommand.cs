using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class SubtractCommand: ICommand
    {
        private double _a;
        private double _b; 
        private double _result;

        public SubtractCommand(double a, double b)
        {
            _a = a;
            _b = b;
        }
        
        public void Execute()
        {
            _result = _a - _b;
            Console.WriteLine($"Результат вычитания: {_result}");
        }

        public void Undo()
        {
            Console.WriteLine($"Отмена вычитания: {_result} + {_b} = {_result + _b}");
        }
    }
}
