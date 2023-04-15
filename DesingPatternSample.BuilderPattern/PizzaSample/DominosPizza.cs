namespace DesingPatternSample.BuilderPattern.PizzaSample
{
    public class DominosPizza : PizzaBuilder
    {
        public override PizzaBuilder SetCheeseType(string cheeseType)
        {
            pizza.CheeseType = cheeseType;
            return this;
        }

        public override PizzaBuilder SetDough(string dough)
        {
            pizza.Dough = dough; 
            return this;
        }

        public override PizzaBuilder SetMaterial(string material)
        {
            pizza.Material = material;
            return this;
        }

        public override PizzaBuilder SetSize(string size)
        {
            pizza.Size = size; 
            return this;
        }
    }



}
