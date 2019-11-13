using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.BLL.Services
{
    public class ProductService:IProductService
    {

        private readonly GiftCardDBContext _context;

        public ProductService(GiftCardDBContext context)
        {
            _context = context;
        }

        public List<Tproduct> GetAllProducts()
        {
            return _context.Tproduct.ToList();
        }
    }
}
