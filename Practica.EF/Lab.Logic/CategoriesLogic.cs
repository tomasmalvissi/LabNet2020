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
    }
}
