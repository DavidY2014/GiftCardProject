using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.Web.Areas.Product.Models
{
    [DataContract]
    public class SaveProductModel
    {
        [DataMember]
        public string Name { get; set; }
        public string Title { get; set; }
        public int Class1 { get; set; }
        public int Class2 { get; set; }
        public string DeliveryArea { get; set; }

        public string BelongSupplier { get; set; }
        public decimal  Cost { get; set; }
        public decimal Price { get; set; }
        public int AvaliableStock { get; set; }
        public int SaleAmount { get; set; }
        public string ProductDetail { get; set; }


        public Tproduct ConvertToEntity()
        {
            var efProduct = new Tproduct();
            efProduct.Name = this.Name;
            efProduct.Code = string.Format("P{0}", DateTime.Now.Second + new Random().Next()); //商品编号
            efProduct.SupplierName = BelongSupplier;
            efProduct.DeliveryAddress = this.DeliveryArea;
            efProduct.Class1 = this.Class1;
            efProduct.Class2 = this.Class2;
            efProduct.SalePrice = this.Price;
            efProduct.TotalStock = this.AvaliableStock;
            efProduct.SaledStock = this.SaleAmount;
            efProduct.Cost = this.Cost;
            efProduct.Description = this.ProductDetail;
            efProduct.Status = "0";
            efProduct.CreateTime = DateTime.Now;
            efProduct.UpdateTime = DateTime.Now;
            return efProduct;
        }

    }
}
