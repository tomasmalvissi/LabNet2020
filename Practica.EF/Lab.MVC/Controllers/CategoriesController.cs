using Lab.Entities;
using Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var logic = new CategoriesLogic();
            var categorias = logic.GetAll();

            return View(categorias);
        }
        [HttpPost]
        public ActionResult Insert(Categories categ)
        {
            var logic = new CategoriesLogic();
            logic.Insert(categ);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var logic = new CategoriesLogic();
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}