using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.BLL.Services
{
    public class SupplierService : ISupplierService
    {
        public List<Tsupplier> GetAllDistinctSuppliers()
        {
            using (var _context = new GiftCardDBContext())
            {
               return  _context.Tsupplier.ToList();
            }
        }

        public void SaveNew(Tsupplier supplier)
        {
            supplier.HardSave();
        }
    }
}
