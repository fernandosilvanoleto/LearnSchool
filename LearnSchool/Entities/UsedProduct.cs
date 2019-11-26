using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedate)
            : base(name, price)
        {
            ManuFactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder(); // MONTAGEM DE STRING           
            sb.AppendLine(Price.ToString() + " (Manufacture date: " + ManuFactureDate.ToString("dd/MM/yyyy") + " ) ");
            return sb.ToString();
        }

    }
}
