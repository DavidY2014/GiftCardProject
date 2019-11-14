using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftCard.BLL.Services;
using GiftCard.Web.Areas.Product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ORM.GiftCardModels;

namespace GiftCard.Web.Areas.Product.Controllers
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        public ProductController(IProductService productService,ISupplierService supplierService)
        {
            _productService = productService;
            _supplierService = supplierService;
        }


        /// <summary>
        /// 主页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 新增，编辑页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            return View();
        }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <returns></returns>

        public ActionResult QueryList()
        {
            var ret = new List<ProductDGModel>();
            var efProducts = _productService.GetAllProducts();
            if (efProducts == null)
            {
                return Json(ret);
            }
            foreach (var item in efProducts)
            {
                ret.Add(new ProductDGModel
                {
                    Name = item.Name,
                    //Title = item.title
                    SupplierName = item.SupplierName,
                    DeliveryAddress = item.DeliveryAddress,
                    Class1 = item.Class1.ToString(),
                    Class2 = item.Class2.ToString(),
                    SalePrice = item.SalePrice.ToString(),
                    TotalStock = item.TotalStock.ToString(),
                    SaleCount = item.SaledStock.ToString(),
                    //AvaliableStock = item
                    Status = item.Status,
                });
            }
            return Json(ret);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveProductInfo(SaveProductModel model)
        {
            var efProduct = model.ConvertToEntity();
            _productService.CreateNewProduct(efProduct);
            return Json(new { IsSuccess=true,Data="Success"});
        }


        #region 下拉列表

        public ActionResult InitSupplierJson()
        {
            var distinctSuppliers = _supplierService.GetAllDistinctSuppliers();
            var ret = distinctSuppliers.Select(item => new ComboxModel { id = item.Id.ToString(), text = item.Name }).Distinct().ToList();
            return Json(ret);
        }


        #endregion

    }
}
