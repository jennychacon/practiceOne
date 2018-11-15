using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductFixPrice : Products
    {
        #region Properties
        public decimal Price { get; set; }

        public float TaxRate { get; set; }
        #endregion

        #region Constructors
        public ProductFixPrice(int productId, string productName, decimal price, float taxRate) : base(productId, productName)
        {
            this.Price = price;
            this.TaxRate = taxRate;
        }
        #endregion

        #region Methods
        public override decimal GetPrice()
        {
            return this.Price * (1 + (decimal)this.TaxRate);
        }

        public override decimal GetTax()
        {
            return this.Price * (decimal)this.TaxRate;
        }
        #endregion

        public override string ToString()
        {
            string cadena = $"{base.ToString()}\n\t" +
                $"Tax..................:{this.GetTax(),12:C2}\n\t" +
                $"Value to pay.........:{this.GetPrice(),12:C2}";
            return cadena;
        }

    }
}
