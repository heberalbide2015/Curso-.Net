using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    public abstract class Cuadrilatero
    {
        protected Vertice SuperiorIzquierdo { get; set; }
        protected Vertice SuperiorDerecho { get; set; }
        protected Vertice InferiorIzquierdo { get; set; }
        protected Vertice InferiorDerecho { get; set; }

        public Cuadrilatero(Vertice superiorIzquierdo, Vertice superiorDerecho, Vertice inferiorIzquierdo, Vertice inferiorDerecho)
        {
            SuperiorIzquierdo = superiorIzquierdo;
            SuperiorDerecho = superiorDerecho;
            InferiorIzquierdo = inferiorIzquierdo;
            InferiorDerecho = inferiorDerecho;
        }

        public abstract double CalcularArea();
    }
}
