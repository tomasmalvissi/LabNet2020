using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.POO
{
    abstract class Transporte
    {
        #region Atributos
        private int pasajeros;
        #endregion

        #region Contructor
        public Transporte(int cantPasajeros)
        {
            pasajeros = cantPasajeros;
        }
        #endregion

        #region Metodos
        public abstract string Avanzar();

        public abstract string Detenerse();
        #endregion
    }
}
