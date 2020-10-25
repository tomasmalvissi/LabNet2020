using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Exceptions
{
    class MisExepciones : Exception
    {
        public MisExepciones() : base("Epa, salto el error") 
        {
            
        }
    }
}
