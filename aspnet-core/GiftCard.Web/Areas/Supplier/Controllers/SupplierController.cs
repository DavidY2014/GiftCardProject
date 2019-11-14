using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftCard.BLL.Services;
using GiftCard.Web.Areas.Supplier.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftCard.Web.Areas.Supplier.Controllers
{
    [Area("Supplier")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        /// <summary>
        /// 列表页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult QueryList()
        {
            var ret = new List<SupplierDataGridModel>();


            return Json(ret);
        }

        public IActionResult SaveSupplier(SupplierEditModel model)
        {
            var efSupplier = model.ConvertToEntity();
           
        }

    }
}
