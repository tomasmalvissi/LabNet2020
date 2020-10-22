using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Transporte[] automovil = new Automovil[5];
            Transporte[] avion = new Avion[5];

            //AUTOS
            for (byte i = 0; i < 5; i++) 
            {
                int pasaj = random.Next(1, 6);
                automovil[i] = new Automovil(pasaj);
                Console.WriteLine("Cantidad de pasajeros en el auto " + (i + 1) + ": " + pasaj);
            }
            Console.WriteLine("");
            //AVIONES
            for (byte i = 0; i < 5; i++) 
            {
                int pasaj = random.Next(50, 110);
                avion[i] = new Avion(pasaj);
                Console.WriteLine("Cantidad de pasajeros en el avion " + (i + 1) + ": " + pasaj);
            }

            Console.ReadKey();
        }
    }
}
