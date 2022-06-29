using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase14
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public Carta()
        {

        }
        public Carta (int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }

    }
}
