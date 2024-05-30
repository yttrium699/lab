using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public interface ICommand //Интерфейс для команд 
    {
        void Execute(); 
        void Undo();
    }
}
