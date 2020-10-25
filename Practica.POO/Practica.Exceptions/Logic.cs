using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Exceptions
{
    public class Logic
    {
        public void Execepcion()
        {
            try
            {
                string a = string.Empty;
                Console.WriteLine(Convert.ToInt32(a));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ExecepcionPer()
        {
            try
            {
                string a = "";
                PracticaExecep.ThrowCustomException();
                Console.WriteLine(Convert.ToInt32(a));
            }
            catch (MisExepciones exper)
            {
                Console.WriteLine(exper.Message);
            }
        }
    }
}
