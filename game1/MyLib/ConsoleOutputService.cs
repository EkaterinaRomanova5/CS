using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class ConsoleOutputService: OutputService //реализация интерфейса вывода в консоль
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
