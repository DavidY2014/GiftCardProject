using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.BLL.Services
{
    public class ProductService:IProductService
    {
        public List<Tproduct> GetAllProducts()
        {
            using (var context = new GiftCardDBContext())
            {
                var efProducts = context.Tproduct;
                if (efProducts.Count() == 0)
                    return null;
                return efProducts.ToList();
            }

        }
    }
}
