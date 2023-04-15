namespace DesingPatternSample.BuilderPattern.PizzaSample
{
    public interface IPizzaBuilder
    {
        Pizza Build();
        PizzaBuilder SetCheeseType(string cheeseType);
        PizzaBuilder SetDough(string dough);
        PizzaBuilder SetMaterial(string material);
        PizzaBuilder SetSize(string size);
    }
}