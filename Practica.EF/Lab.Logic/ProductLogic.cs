using Lab.Data;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class ProductLogic
    {
        private readonly DataContext context;
        public ProductLogic()
        {
            this.context = new DataContext();
        }
        public List<Products> Products()
        {
            return context.Products.ToList();
        }
        public Products Producto(int id)
        {
            return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
        }
    }
}
