using SalesManagementApplication.DAL;
using SalesManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        private SalesTaskDbContext db = new SalesTaskDbContext();
        public ActionResult Index()
        {
            HomePageNew homePageNew = new HomePageNew();
            var sunoloPwlhtwn = db.Seller.Select(a => a.Id).Count();
            var sunoloPwlhsewn = db.Sale.Select(a => a.TransactionAmount).Count();
            homePageNew.TotalSales = sunoloPwlhsewn;
            homePageNew.TotalSellers = sunoloPwlhtwn;
            return View(homePageNew);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}