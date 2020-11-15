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
            try
            {
                var logic = new CategoriesLogic();
                var categorias = logic.GetAll();

                return View(categorias);
            }
            catch (Exception ex)
            {
                TempData["exMessage"] = ex.Message;
                return RedirectToAction("Error", "Error");
            }
            
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Categories categ)
        {
            try 
            {
                var logic = new CategoriesLogic();
                logic.Insert(categ);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["exMessage"] = ex.Message;
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var logic = new CategoriesLogic();
                var categorias = logic.GetOne(id);

                return View(categorias);
            }
            catch (Exception ex)
            {
                TempData["exMessage"] = ex.Message;
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(Categories categ)
        {
            try
            {
                var logic = new CategoriesLogic();
                logic.Update(categ);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["exMessage"] = ex.Message;
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var logic = new CategoriesLogic();
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["exMessage"] = ex.Message;
                return RedirectToAction("Error", "Error");
            }
        }
    }
}