using BuilderDesignPattern.ConcreteBuilder;
using BuilderDesignPattern.Director;
using Newtonsoft.Json;
using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerBuilder = new BurgerBuilder();
            var burgerDirector = new BurgerDirector(burgerBuilder);
            
            burgerDirector.ConstructCheeseBurger();
            var cheeseBurger = burgerBuilder.GetBurger();
            Console.WriteLine($"Burger: {JsonConvert.SerializeObject(cheeseBurger)}");
        }
    }
}