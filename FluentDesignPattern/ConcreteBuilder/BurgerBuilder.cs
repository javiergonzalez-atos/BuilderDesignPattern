using FluentDesignPattern.Product;
using FluentDesignPattern.Builder;

namespace FluentDesignPattern.ConcreteBuilder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder()
        {
            _burger = new Burger();
        }

        public Burger GetBurger()
        {
            return _burger;
        }

        public BurgerBuilder AddPatties(int pattiesNumber)
        {
            _burger.PattiesNumber = pattiesNumber;
            return this;
        }
        
        public BurgerBuilder WithKetchup()
        {
            _burger.Ketchup = true;
            return this;
        }

        public BurgerBuilder WithPineapple()
        {
            _burger.Pineapple = true;
            return this;
        }

        public BurgerBuilder WithBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public BurgerBuilder WithCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public BurgerBuilder WithOnion()
        {
            _burger.Onion = true;
            return this;
        }

        public BurgerBuilder WithTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public BurgerBuilder WithPickles()
        {
            _burger.Pickles = true;
            return this;
        }
    }
}