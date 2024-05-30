using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main()
        {
            CommandInvoker invoker = new CommandInvoker();
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            string operation = Console.ReadLine();

            ICommand command = null; //Создание команды
            switch (operation)
            {
                case "сложить":
                    command = new AddCommand(a, b);
                    break;
                case "вычесть":
                    command = new SubtractCommand(a, b);
                    break;
                case "умножить":
                    command = new MultiplayCommand(a, b);
                    break;
                case "разделить":
                    command = new DivideCommand(a, b);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    return;
            }

            invoker.ExecuteCommand(command); //Выполнение команды

            Console.WriteLine("Отменить последнюю операцию?"); //Возможность отмены последней операции
            string undo = Console.ReadLine();
            if (undo.ToLower() == "да")
            {
                invoker.UndoLastCommand();
            }    
        }
    }
}
