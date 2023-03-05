using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinifde_yazilan.Models
{
    public class Book : Product
    {
        public string autherName;
        public int pageCount;
        public int discountPercent;

        public Book(string productName, int costPrice, int saledPrice, string autherName, int pageCount, int discountPercent) : base(productName, costPrice, saledPrice)
        {
            this.autherName = autherName;
            this.pageCount = pageCount;
            this.discountPercent = discountPercent;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{productName},{costPrice},{saledPrice},{autherName},{pageCount},{discountPercent}");
        }
        public int GetDiscountedPrice()
        {
            return costPrice - (costPrice * discountPercent / 100);
        }
    }
}
