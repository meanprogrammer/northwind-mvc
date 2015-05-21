using Northwind.Mvc.Data.Models;
using Northwind.Mvc.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Mvc.Web.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        CategoryRepository repo = new CategoryRepository();

        public ActionResult Index()
        {
            var list =repo.GetAll();
            return View(list);
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return PartialView("_Create", new Category());
        }

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return PartialView("_Create");
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Category/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Category/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
