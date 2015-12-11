using System.Collections.Generic;

namespace ODataSample.Web.Models
{
    using Microsoft.AspNet.OData.Builder;

    public class Customer
    {
        private List<Product> _products;

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Contained]
        public List<Product> Products
        {
            get
            {
                return _products ?? (_products = new List<Product>());
            }
            set
            {
                _products = value;
            }
        }
    }
}
