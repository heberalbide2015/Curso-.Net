namespace Cuadrilateros.Modelo
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio(Vertice superiorIzquierdo, Vertice superiorDerecho, Vertice inferiorIzquierdo, Vertice inferiorDerecho) 
            : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override double CalcularArea()
        {
            return ((SuperiorDerecho.X - SuperiorIzquierdo.X + InferiorDerecho.X - InferiorIzquierdo.X) * (SuperiorDerecho.Y - InferiorDerecho.Y) / 2);

        }
    }
}