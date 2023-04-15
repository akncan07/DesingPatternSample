namespace DesignPatternSample.FactoryPattern.Menu.Abstract
{
    public interface  IMenu
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int PreparationTime { get; set; }
    }

}