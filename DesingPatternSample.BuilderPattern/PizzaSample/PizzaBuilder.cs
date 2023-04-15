namespace DesingPatternSample.BuilderPattern.PizzaSample
{
    public abstract class PizzaBuilder : IPizzaBuilder
    {
        protected Pizza pizza { get; set; }

        public PizzaBuilder()
        {
            pizza = new Pizza();
        }

        public abstract PizzaBuilder SetSize(string size);
        public abstract PizzaBuilder SetCheeseType(string cheeseType);
        public abstract PizzaBuilder SetMaterial(string material);
        public abstract PizzaBuilder SetDough(string dough);
        public Pizza Build() => pizza;
    }



}
