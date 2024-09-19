using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RandomNumberGenerator: NumberGenerator //реализация интерфейса генерации случайных чисел
    {
        private Random random = new Random();
        public int Generate(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
