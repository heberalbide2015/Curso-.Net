using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Modelo
{
    public class Carta
    {
        public string Palo { get; set; }
        public int Numero { get; set; }

        public Carta(string palo, int numero)
        {
            Palo = palo;
            Numero = numero;

        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }

   
}
