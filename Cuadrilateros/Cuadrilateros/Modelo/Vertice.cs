using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    public class Vertice
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}
