using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Exceptions
{
    public class PracticaExecep
    {
        public static void ThrowCustomException()
        {
            throw new MisExepciones();
        }
        public void DivPorCero(int d1)
        {
            try
            {
                int res = d1 / 0;
                Console.WriteLine($"Operacion realizada, el resultado es: {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Operacion no realizada porque: {ex.Message}");
            }
        }
        public void Division(int d1, int d2)
        {
            try
            {
                int division = d1 / d2;
                Console.WriteLine($"El resultado es: {division}");
            }
            catch (DivideByZeroException ex0)
            {
                Console.WriteLine($"Ni el tipo de Duro de Matar dividio por cero. \n {ex0.Message}");
            }
            catch (Exception) 
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
            }
            
        }

    }
}
