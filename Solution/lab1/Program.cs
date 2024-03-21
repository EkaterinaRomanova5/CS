using System;
using System.Security.Cryptography.X509Certificates;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заводы:");
            var factories = Factory.GetFactories();

            foreach (Factory fact in factories)
            {
                Console.WriteLine($"ID: {fact.ID}, Name: {fact.Name}, Description: {fact.Description}");
            }

            Console.WriteLine("\nУстановки:");
            var units = Unit.GetUnits();

            foreach (Unit unit in units)
            {
                Console.WriteLine($"ID: {unit.ID}, Name: {unit.Name}, Description: {unit.Description}, FactoryID: {unit.FactoryID}");
            }

            Console.WriteLine("\nРезервуары:");
            var tanks = Tank.GetTanks();
            foreach (Tank tank in tanks)
            {
                Console.WriteLine($"ID: {tank.ID}, Name: {tank.Name}, Description: {tank.Description}, Volume: {tank.Volume}, MaxVolume: {tank.MaxVolume}, UnitID: {tank.UnitID}");
            }

            Console.WriteLine($"\nКоличество резервуаров: {tanks.Length}, установок: {units.Length}");

            var foundUnit = Unit.FindUnit(units, tanks, "Резервуар 35");

            var factory = Factory.FindFactory(factories, foundUnit);


            Console.WriteLine($"Резервуар 35 принадлежит установке {foundUnit.Name} и заводу {factory.Name}");

            var totalVolume = Tank.GetTotalVolume(tanks);
            Console.WriteLine($"Общий объем резервуаров: {totalVolume}");

            Console.WriteLine("Введите название резервуара: ");
            string tankName=Console.ReadLine(); //вводим название резервуара

            //поиск резервуара по введенному названию
            foreach(Tank tank in tanks)
            {
                if (tank.Name.ToLower() == tankName.ToLower())
                {
                    Console.WriteLine($"ID: {tank.ID}, Name: {tank.Name}, Description: {tank.Description}, Volume: {tank.Volume}, MaxVolume: {tank.MaxVolume}, UnitID: {tank.UnitID}, Unit: {foundUnit.Name}, Factory: {factory.Name}");
                    return;
                }
            }
            Console.WriteLine("Такого резервуара нет!");
        }
    }
}