using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiftCard.Web.Areas.Product.Controllers
{
    [Area("Product")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
