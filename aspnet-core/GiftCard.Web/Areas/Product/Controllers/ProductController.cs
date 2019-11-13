using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftCard.BLL.Services;
using GiftCard.Web.Areas.Product.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftCard.Web.Areas.Product.Controllers
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
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
            var ret = new List<ProductModel>();
            var efProducts = _productService.GetAllProducts();
            if (efProducts == null)
            {
                return Json(ret);
            }
            foreach (var item in efProducts)
            {
                ret.Add(new ProductModel {
                    Name=item.Name,
                    Code = item.Code
                });
            }
            return Json(ret);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveProductInfo()
        {


            return Json(new { });
        }


    }
}
