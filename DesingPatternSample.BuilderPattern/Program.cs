using DesingPatternSample.BuilderPattern.EmployeeSample;
using DesingPatternSample.BuilderPattern.PizzaSample;

namespace DesingPatternSample.BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePizzaOrder(0));
        }

        static string CreatePizzaOrder(int pizzaSeller)
        {
            IPizzaBuilder pizzaBuilder;

            int sizeCount = new Random().Next(0, 2);
            int cheeseTypeCount = new Random().Next(0, 4);
            int materialCount = new Random().Next(0, 5);
            int doughCount = new Random().Next(0, 2);


            if (pizzaSeller == 0)
            {
                //Dominos
                pizzaBuilder = new DominosPizza();

            }
            else if (pizzaSeller == 1)
            {
                pizzaBuilder = new SbarroPizza();
            }
            else
            {
                throw new Exception("İstediğiniz satıcı su anda hizmet veremiyor");
            }

            var order = pizzaBuilder
                .SetSize(PizzaIngredients.Sizes[sizeCount])
                .SetMaterial(PizzaIngredients.Material[materialCount])
                .SetCheeseType(PizzaIngredients.CheeseTypes[cheeseTypeCount])
                .SetDough(PizzaIngredients.Doughs[doughCount])
                .Build();

            return order.ToString();

        }

        static void EmployeDirector()
        {
            IEmployeBuilder empBuilder = new CompanyEmployee();

            var emp = empBuilder
                .SetFullName("akıncan aksoy")
                .SetEmailAddress("akncan01.1@gmail.com")
                .SetUserName("akncan").BuildEmployee();
            Console.WriteLine(emp.Email);
        }
    }
}