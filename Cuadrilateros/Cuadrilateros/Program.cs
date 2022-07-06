// See https://aka.ms/new-console-template for more information
using Cuadrilateros.Modelo;
//Rectángulo
Vertice supIzqR = new Vertice(1, 5);
Vertice supDerR = new Vertice(5, 5);
Vertice infIzqR = new Vertice(2, 2);
Vertice infDerR = new Vertice(5, 2);
//Cuadrado
Vertice supIzqC = new Vertice(1, 5);
Vertice supDerC = new Vertice(5, 5);
Vertice infIzqC = new Vertice(1, 1);
Vertice infDerC = new Vertice(5, 1);
//Trapecio
Vertice supIzqT = new Vertice(3, 5);
Vertice supDerT = new Vertice(4, 5);
Vertice infIzqT = new Vertice(1, 1);
Vertice infDerT = new Vertice(5, 1);

Cuadrado c = new Cuadrado(supIzqC, supDerC, infIzqC, infDerC);
Console.WriteLine(c.CalcularArea());

Rectangulo r = new Rectangulo(supIzqR, supDerR, infIzqR, infDerR);
Console.WriteLine(r.CalcularArea());

Trapecio t = new Trapecio(supIzqT, supDerT, infIzqT, infDerT);
Console.WriteLine(t.CalcularArea());


