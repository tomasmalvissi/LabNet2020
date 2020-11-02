using Lab.Data;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CategoriesLogic
    {
        private readonly DataContext context;
        public CategoriesLogic()
        {
            this.context = new DataContext();
        }
        public List<Categories> Categories()
        {
            DataContext context = new DataContext();
            return context.Categories.ToList();
        }
        public Categories Categoria(int id)
        {
            return context.Categories.FirstOrDefault(r => r.CategoryID.Equals(id));
        }
    }
}
