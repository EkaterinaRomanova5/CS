using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    /// Завод
    public class Factory
    {
        //свойства класса
        public int ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        //конструктор класса
        public Factory(int id, string name, string description) {
            ID = id;
            Name = name;
            Description = description;
        }
        //метод, который возвращает массив заводов
        public static Factory[] GetFactories()
        {
            Factory[] factories = new Factory[] {
            new Factory(1, "НПЗ№1", "Первый нефтеперерабатывающий завод"),
            new Factory(2, "НПЗ№2", "Второй нефтеперерабатывающий завод")
        };
        return factories;
        }

        // реализуйте этот метод, чтобы он возвращал объект завода, соответствующий установке
        public static Factory FindFactory(Factory[] factories, Unit unit)
        {
            foreach (Factory fact in factories)
            {
                if (fact.ID == unit.FactoryID)
                {
                    return fact;
                }
            }
            return null;
        }
    }
}
