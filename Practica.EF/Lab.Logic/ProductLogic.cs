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
    }
}
