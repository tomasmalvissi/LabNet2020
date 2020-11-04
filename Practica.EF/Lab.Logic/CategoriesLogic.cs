using Lab.Data;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CategoriesLogic : BaseLogic
    {

        public List<Categories> GetAll()
        {
            DataContext context = new DataContext();
            return context.Categories.ToList();
        }

        public Categories GetOne(int id)
        {
            return context.Categories.FirstOrDefault(r => r.CategoryID.Equals(id));
        }

        public Categories Insert(Categories entity)
        {
            int ultID = (from cat in context.Categories     //ordeno y traigo el ult id
                         orderby cat.CategoryID descending
                         select cat.CategoryID
                         ).FirstOrDefault();
            ultID++;
            entity.CategoryID = ultID;
            Categories newCat = context.Categories.Add(entity);
            context.SaveChanges();
            return newCat;
        }

        public void Update(Categories entity)
        {
            Categories catEdit = GetOne(entity.CategoryID);
            catEdit.CategoryName = entity.CategoryName;
            catEdit.Description = entity.Description;

            context.Entry(catEdit).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Categories catDel = GetOne(id);
            context.Categories.Remove(catDel);
            context.SaveChanges();
        }
    }
}
