using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class AddCommand : ICommand //класс для сложения
    {
        private double _a;
        private double _b;
        private double _result;

        public AddCommand(double a, double b) //Конструктор команды, принимающий 2 числа
        {
            _a = a;
            _b = b;
        }
        public void Execute() //Выполнение сложения
        {
            _result = _a + _b;
            Console.WriteLine($"Результат сложения: {_result}");
        }

        public void Undo() //Отмена сложения
        {
            Console.WriteLine($"Отмена сложения: {_result} - {_b} = {_result - _b}");
        }
    }
}
