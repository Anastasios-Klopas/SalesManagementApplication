using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesManagementApplication.DAL;
using SalesManagementApplication.Models;

namespace SalesManagementApplication.Controllers
{
    public class SellersController : Controller
    {
        private SalesTaskDbContext db = new SalesTaskDbContext();

        // GET: Sellers
        public ActionResult Index()
        {
            var seller = db.Seller.Include(s => s.Sales).ToList();
            seller.ForEach(s => s.Supply = s.Sales.Select(a => a.TransactionAmount).Sum() * 0.10m);
            return View(seller);
        }

        // GET: Sellers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = db.Seller.Find(id);
            //shmerinh xronia
            var xronia = DateTime.Now.Year;
            //grouparisma ana xrono ta Sales tou ka8e pwlhth
            var groupSalesPerYear = seller.Sales.GroupBy(yearGroup => yearGroup.DateOfSale.Year);
            seller.SalesPerYearPerSeller = groupSalesPerYear;

            //grouparisma ana mhna tou ka8e xronou gia ton ka8e pwlhth
            var groupSalesPerMonthPerCurrentYear = groupSalesPerYear.Select(year => year.GroupBy(monthGroup => monthGroup.DateOfSale.Month));
            seller.SalesPerYearPerMonthSeller = groupSalesPerMonthPerCurrentYear;

            ////ola mazi ta panw 2 grouparismata
            //var groupSalesPerMonthPerCurrentYear = seller.Sales.GroupBy(yearGroup => yearGroup.DateOfSale.Year).Select(year => year.GroupBy(monthGroup => monthGroup.DateOfSale.Month));

            //ka8e mhna tou trexontos etous promh8eia tou ka8e pwlhth
            var supplyNew = groupSalesPerMonthPerCurrentYear.Select(year => year.Select(month => month.Select(transAmount => transAmount.TransactionAmount).Sum() * 0.1m));
            // seller.SupplyPerSeller = supplyNew;

            //ka8e mhna tou trexontos etous sunolo pwlhsewn tou ka8e pwlhth
            var countSupplyNew = groupSalesPerMonthPerCurrentYear.Select(year => year.Select(month => month.Select(transAmount => transAmount.TransactionAmount).Count()));
            //seller.CountSalesPerSeller = countSupplyNew;

            // grouparisma ana mhna ta Sales tou ka8e pwlhth
            var groupSalesPerMonth = seller.Sales.GroupBy(month => month.DateOfSale.Month);
            // ka8e mhna promh8eia tou ka8e pwlhth
            seller.SupplyPerSeller = groupSalesPerMonth.Select(month => month.Select(transAmount => transAmount.TransactionAmount).Sum() * 0.1m);
            // ka8e mhna pwlhseis tou ka8e pwlhth
            seller.CountSalesPerSeller = groupSalesPerMonth.Select(month => month.Select(transAmount => transAmount.TransactionAmount).Count());
           
            Dictionary<int, string> monthPerKey = new Dictionary<int, string>
            {
                { 1, "January" },
                { 2, "February" },
                { 3, "March" },
                { 4, "April" },
                { 5, "May" },
                { 6, "June" },
                { 7, "July" },
                { 8, "August" },
                { 9, "September" },
                { 10, "October" },
                { 11, "November" },
                { 12, "December" }
            };
            seller.MonthPerKey = monthPerKey;
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // GET: Sellers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                db.Seller.Add(seller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seller);
        }

        // GET: Sellers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = db.Seller.Find(id);
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName")] Seller seller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seller);
        }

        // GET: Sellers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seller seller = db.Seller.Find(id);
            if (seller == null)
            {
                return HttpNotFound();
            }
            return View(seller);
        }

        // POST: Sellers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seller seller = db.Seller.Find(id);
            db.Seller.Remove(seller);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
