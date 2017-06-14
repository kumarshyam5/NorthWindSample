using Northwind.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService service;
        public CategoryController(ICategoryService _service)
        {
            service = _service;
        }

        // GET: Category
        public ActionResult Index()
        {
            var category = service.GetAllCategories();
            return View();
        }
    }
}