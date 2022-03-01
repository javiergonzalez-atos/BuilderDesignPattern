using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Product;

namespace BuilderDesignPattern.ConcreteBuilder
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

        public void AddPatties(int pattiesNumber)
        {
            _burger.PattiesNumber = pattiesNumber;
        }
        
        public void WithKetchup()
        {
            _burger.Ketchup = true;
        }

        public void WithPineapple()
        {
            _burger.Pineapple = true;
        }

        public void WithBacon()
        {
            _burger.Bacon = true;
        }

        public void WithCheese()
        {
            _burger.Cheese = true;
        }

        public void WithOnion()
        {
            _burger.Onion = true;
        }

        public void WithTomato()
        {
            _burger.Tomato = true;
        }

        public void WithPickles()
        {
            _burger.Pickles = true;
        }
    }
}