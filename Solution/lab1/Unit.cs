using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Unit
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FactoryID { get; }
        public Unit(int id, string name, string description, int factoryid)
        {
            ID = id;
            Name = name;
            Description = description;
            FactoryID = factoryid;
        }
        public static Unit[] GetUnits()
        {
            Unit[] units = new Unit[] {
            new Unit(1, "ГФУ-2", "Газофракционирующая установка", 1),
            new Unit(2, "АВТ-6", "Атмосферно-вакуумная трубчатка", 1),
            new Unit(3, "АВТ-10", "Атмосферно-вакуумная трубчатка", 2)
        };
            return units;
        }

        // реализуйте этот метод, чтобы он возвращал установку (Unit), которой
        // принадлежит резервуар (Tank), найденный в массиве резервуаров по имени
        // учтите, что по заданному имени может быть не найден резервуар
        public static Unit FindUnit(Unit[] units, Tank[] tanks, string tankName)
        {
            foreach (Tank tank in tanks)
            {
                if (tank.Name == tankName)
                {
                    foreach (Unit unit in units)
                    {
                        if (unit.ID == tank.UnitID)
                        {
                            return unit;
                        }
                    }
                }
            }
            return null; //если не находит установку, то возвращает 0
        }
    }
}
