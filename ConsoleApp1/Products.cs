using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Products
    {
        #region properties
        public int ProductId { get; set; }

        public string Name { get; set; }

        #endregion

        #region Constructors
        public Products(int productId, string productName)
        {
            this.ProductId = productId;
            this.Name = productName;
        }
        #endregion

        #region Methods

        public abstract decimal GetPrice();

        public abstract decimal GetTax();

        public override string ToString()
        {
            return $"{this.ProductId,6} {this.Name}";
        }
        #endregion
    }
}
