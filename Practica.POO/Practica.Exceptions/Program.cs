using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            PracticaExecep pracexep = new PracticaExecep();
            pracexep.DivPorCero(4);
            Console.WriteLine();
            //2
            pracexep.Division(400,5);
            Console.WriteLine();
            //3
            Logic logic = new Logic();
            logic.Execepcion();
            //4
            logic.ExecepcionPer();


            Console.ReadKey();
        }
    }
}
