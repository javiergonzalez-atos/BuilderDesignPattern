using System;
using FluentDesignPattern.ConcreteBuilder;
using Newtonsoft.Json;

namespace FluentDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerBuilder = new BurgerBuilder();
            var tripleHawaiianBaconBurger = burgerBuilder.AddPatties(3).WithPineapple().WithBacon().GetBurger();

            Console.WriteLine($"Burger: {JsonConvert.SerializeObject(tripleHawaiianBaconBurger)}");
            
        }
    }
}