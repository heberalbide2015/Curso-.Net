namespace Cuadrilateros.Modelo
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(Vertice superiorIzquierdo, Vertice superiorDerecho, Vertice inferiorIzquierdo, Vertice inferiorDerecho) 
            : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override double CalcularArea()
        {
            return Math.Pow((SuperiorDerecho.X - SuperiorIzquierdo.X), 2);
        }
    }
        
        
}
