using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.POO
{
    class Automovil : Transporte
    {
        public Automovil(int cantPasajeros) : base(cantPasajeros)
        {
        }

        public override string Avanzar()
        {
            return "Auto avanzando...";
        }

        public override string Detenerse()
        {
            return "Auto detenido";
        }
    }
}
