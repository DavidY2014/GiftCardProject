using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.BLL.Services
{
    public interface ISupplierService
    {
        List<Tsupplier> GetAllDistinctSuppliers();
    }
}
