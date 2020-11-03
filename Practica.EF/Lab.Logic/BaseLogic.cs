using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public abstract class BaseLogic //instancio el context una vez para no repetirlo en cada clase Logic
    {
        protected readonly DataContext context;

        public BaseLogic()
        {
            this.context = new DataContext();
        }
    }
}
