using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Apple_Clone_Website.Models;

namespace Apple_Clone_Website.Controllers
{
    public class ProductsController : Controller
    {
        private AppleStoreEntities db = new AppleStoreEntities();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }


        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.SingleOrDefault(n => n.ProductID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

    }
}
