using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.BLL.Services
{
    /// <summary>
    /// EF 扩展工具包
    /// </summary>
    public  static class EFExtension
    {
        public static void HardSave(this Tsupplier supplier)
        {
            using (var _context = new GiftCardDBContext())
            {
                _context.Tsupplier.Add(supplier);
                _context.SaveChanges();
            }
        }



    }
}
