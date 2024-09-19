using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public interface NumberGenerator //интерфейс для генерации чисел
    {
        int Generate(int min, int max);
    }
}
