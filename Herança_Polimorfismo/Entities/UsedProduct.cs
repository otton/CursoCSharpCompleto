using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Herança_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufatureDate)
            : base(name, price)
        {
            ManufactureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
