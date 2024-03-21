using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Tank
    {
        //свойства класса
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Volume { get; }
        public int MaxVolume { get; }
        public int UnitID { get; }
        //конструктор класса
        public Tank(int id, string name, string description, int volume, int maxvolume, int unitid)
        {
            ID = id;
            Name = name;
            Description = description;
            Volume = volume;
            MaxVolume = maxvolume;
            UnitID = unitid;
        }
        //метод, который возвращает массив заводов
        public static Tank[] GetTanks()
        {
            Tank[] tanks = new Tank[] {
            new Tank(1, "Резервуар 1", "Надземный-вертикальный", 1500, 2000, 1),
            new Tank(2, "Резервуар 2", "Надземный-горизонтальный", 2500, 3000, 1),
            new Tank(3, "Дополнительный резервуар 24", "Надземный-горизонтальный", 3000, 3000, 2),
            new Tank(4, "Резервуар 35", "Надземный-вертикальный", 3000, 3000, 2),
            new Tank(5, "Резервуар 47", "Подземный-двустенный", 4000, 5000, 2),
            new Tank(6, "Резервуар 256", "Подводный", 500, 500, 3),
        };
            return tanks;
        }

        public static int GetTotalVolume(Tank[] tanks)
        {
            int totalVolume = 0;
            foreach (Tank tank in tanks)
            {
                totalVolume += tank.Volume;
            }
            return totalVolume;
        }
    }
}
