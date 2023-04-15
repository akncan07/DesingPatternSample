using DesignPatternSample.FactoryPattern.Menu.Abstract;

namespace DesignPatternSample.FactoryPattern.Menu
{
    public class ItalianMenu : IMenu
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int PreparationTime { get; set;}
      
    }





}