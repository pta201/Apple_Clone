using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;

namespace Apple_Clone_Website.Controllers
{
    public class IndexViewDataController : Controller
    {
        // GET: IndexViewData
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            //mymodel.Product = ProductsController.GetProduct();
            //mymodel.Students = GetStudents();
            return View(mymodel);

        }
    }
}