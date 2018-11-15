using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CompositedProduct : Products
    {

        #region Properties
        public List<Products> Products { get; set; }
        #endregion

        #region Constructors
        public CompositedProduct(int productId, string productName, List<Products> products) : base(productId, productName)
        {
            this.Products = products;
        }
        #endregion

        #region Methods
        public override decimal GetPrice()
        {
            throw new NotImplementedException();
        }

        public override decimal GetTax()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
