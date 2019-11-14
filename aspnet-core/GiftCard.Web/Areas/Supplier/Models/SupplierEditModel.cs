using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.Web.Areas.Supplier.Models
{
    /// <summary>
    /// 新建model
    /// </summary>
    public class SupplierEditModel
    {


        public Tsupplier ConvertToEntity()
        {
            var efSupplier = new Tsupplier();


            return efSupplier;
        }

    }
}
