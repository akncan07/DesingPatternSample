using DesignPatternSample.FactoryPattern.Customer;
using DesignPatternSample.FactoryPattern.Menu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.FactoryPattern.Menu
{
    public class MenuFactory
    {
        public static IMenu AddMenu(Country country, string name, double price,int preparationTime)
        {
            if (country.Equals(Country.Italian))
            {
                return new ItalianMenu() { Name=name, PreparationTime=preparationTime,Price=price};
            }
            else if (country.Equals(Country.Japan))
            {
                return new JapaneseMenu() { Name = name, PreparationTime = preparationTime, Price = price };
            }
            else if (country.Equals(Country.Turkey))
            {
                return new TurkishMenu() { Name = name, PreparationTime = preparationTime, Price = price };
            }
            else
            {
                throw new ArgumentException("Invalid menu type specified");
            }
        }
    }
}
