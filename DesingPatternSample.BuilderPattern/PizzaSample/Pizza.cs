using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSample.BuilderPattern.PizzaSample
{
    public class Pizza
    {
        public string? Size { get; set; }
        public string? CheeseType { get; set; }
        public string? Material { get; set; }
        public string? Dough { get; set; }

        public override string ToString()
        {
            var order = $"**Sipariş Oluşturuldu** \n Boyut={Size} \n Peynir Tipi={CheeseType} \n Malzemeler={Material} \n Hamur Kalınlığı={Dough}";
            return order;
        }

    }



}
