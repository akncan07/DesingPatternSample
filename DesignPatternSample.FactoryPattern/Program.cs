
using DesignPatternSample.FactoryPattern.Customer;
using DesignPatternSample.FactoryPattern.Menu;

namespace DesignPatternSample.FactoryPattern
{
    /*
     Bir restoranın menüsü, yemekler ve içecekler gibi farklı türde öğeler içerir. 
     Her bir öğe, fiyatı ve adı gibi özelliklere sahiptir. 
     Ayrıca, restoranın menüsü farklı ülkelerde farklı olabilir.
     Örneğin, bir restoranın menüsü, Japon mutfağına ait yemeklerin yer aldığı Japonya'da farklı olabilir.
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            var menu = MenuFactory.AddMenu(Country.Turkey, "Makarna", 100, 17);

            Console.WriteLine(menu.Name);




        }
    }





}