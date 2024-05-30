using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите ФИО спортсмена: ");

                string name = Console.ReadLine();

                Console.WriteLine("Введите время спортсмена: ");

                string timeStr = Console.ReadLine();

                int time = Convert.ToInt32(timeStr ?? throw new ArgumentNullException("Время не может быть пустым")); //Проверяем что введено время

                if (time == 0) //Проверяем, что не 0
                {
                    throw new ZeroTimeException("Время не может быть нулевым");
                }
                Console.WriteLine($"Спортсмен {name} пробежал дистанцию за {time} минут");
            }
            catch (ZeroTimeException ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректное время");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошбка {ex.Message}");
            }
        }
    }
}
