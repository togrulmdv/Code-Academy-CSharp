using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifde_yazilan.Models
{
    public class Product
    {
        public string productName;
        public int costPrice;
        public int saledPrice;
    public Product(string productName, int costPrice, int saledPrice)
        {
            this.productName = productName;
            this.costPrice = costPrice;
            this.saledPrice = saledPrice;
        }
    }
}
