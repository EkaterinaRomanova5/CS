using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class ConsoleInputService: InputService
    {
        public int GetInput()
        {
            Console.Write("Введите число от 1 до 100: ");
            if (int.TryParse(Console.ReadLine(), out int result)) 
            { 
                return result;
            }
            Console.WriteLine("Неправильный ввод. Попробуйте снова!");
            return GetInput();
        }
    }
}
