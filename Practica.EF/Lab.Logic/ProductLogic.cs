using Lab.Data;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class ProductLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public Products GetOne(int id)
        {
            return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
        }

        public Products Insert(Products entity)
        {
            int ultID = (from prod in context.Products     //ordeno y traigo el ult id
                         orderby prod.ProductID descending
                         select prod.ProductID
                         ).FirstOrDefault();
            ultID++;
            entity.ProductID = ultID;
            Products newProd = context.Products.Add(entity);
            context.SaveChanges();
            return newProd;
        }

        public void Update(Products entity)
        {
            Products prodEdit = GetOne(entity.ProductID);
            prodEdit.ProductName = entity.ProductName;
            prodEdit.QuantityPerUnit = entity.QuantityPerUnit;
            prodEdit.UnitPrice = entity.UnitPrice;
            prodEdit.UnitsInStock = entity.UnitsInStock;
            prodEdit.UnitsOnOrder = entity.UnitsOnOrder;
            prodEdit.ReorderLevel = entity.ReorderLevel;

            context.Entry(prodEdit).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Products prodDel = GetOne(id);
            context.Products.Remove(prodDel);
            context.SaveChanges();
        }
    }
}
