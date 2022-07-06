namespace Cuadrilateros.Modelo
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo(Vertice superiorIzquierdo, Vertice superiorDerecho, Vertice inferiorIzquierdo, Vertice inferiorDerecho) 
            : base(superiorIzquierdo, superiorDerecho, inferiorIzquierdo, inferiorDerecho)
        {

        }
        public override double CalcularArea()
        {
            return (SuperiorDerecho.X - SuperiorIzquierdo.X) * (SuperiorDerecho.Y - InferiorDerecho.Y);

        }
    }


}