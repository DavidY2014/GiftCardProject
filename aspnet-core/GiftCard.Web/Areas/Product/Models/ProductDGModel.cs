using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftCard.Web.Areas.Product.Models
{
    public class ProductDGModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string SupplierName { get; set; }
        public string DeliveryAddress { get; set; }
        public string Class1 { get; set; }
        public string Class2 { get; set; }
        public string SalePrice { get; set; }
        public string TotalStock { get; set; }
        public string SaleCount { get; set; }
        public string AvaliableStock { get; set; }
        public string Status { get; set; }
        public string Operation { get; set; }
    }
}
