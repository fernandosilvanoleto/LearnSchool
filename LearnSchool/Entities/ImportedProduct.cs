using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsfee)
            : base(name, price)
        {
            CustomsFee = customsfee;
        }

        public double TotalPrice()
        {
            double totalprice = CustomsFee + Price;
            return totalprice;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder(); // MONTAGEM DE STRING           
                sb.AppendLine(TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " Customns fee " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
