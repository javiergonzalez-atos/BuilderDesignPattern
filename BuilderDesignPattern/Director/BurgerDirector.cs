using BuilderDesignPattern.ConcreteBuilder;

namespace BuilderDesignPattern.Director
{
    public class BurgerDirector
    {
        private readonly BurgerBuilder _burgerBuilder;

        public BurgerDirector(BurgerBuilder burgerBuilder)
        {
            _burgerBuilder = burgerBuilder;
        }

        public void ConstructCheeseBurger()
        {
            _burgerBuilder.AddPatties(1);
            _burgerBuilder.WithCheese();
        }

        public void ConstructDoubleBaconCheeseBurger()
        {
            _burgerBuilder.AddPatties(2);
            _burgerBuilder.WithCheese();
            _burgerBuilder.WithBacon();
        }

        public void ConstructTripleHawaiianBurger()
        {
            _burgerBuilder.AddPatties(3);
            _burgerBuilder.WithPineapple();
            _burgerBuilder.WithKetchup();
        }
    }
}