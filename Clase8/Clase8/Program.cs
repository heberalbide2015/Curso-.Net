// See https://aka.ms/new-console-template for more information

Console.Write("Por favor ingrese la cantidad de precios que desea cargar de cada producto: ");
int cantFilas =  int.Parse(Console.ReadLine());

Console.Write("Por favor ingrese la cantidad de productos que desea comparar: ");
int cantColumnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantFilas, cantColumnas];
float [] promedios = new float[cantColumnas];

int ultimaFila = numeros.GetUpperBound(0);
int ultimaColumna = numeros.GetUpperBound(1);

for (int columna = 0; columna <= ultimaColumna; columna++) {
    for (int fila = 0; fila <= ultimaFila; fila++)
    {

        Console.Write($"Ingrese el valor {fila + 1} del producto {columna + 1}: $");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
  
}

for (int columna = 0; columna <= ultimaColumna; columna++)
{
    float total = 0;
    for (int fila = 0; fila <= ultimaFila; fila++)
    {
        total += numeros[fila, columna];
    }
    
    promedios[columna] = total/(ultimaFila+1);


}
Console.WriteLine();
for(int columna = 0; columna <= ultimaColumna; columna++)
{
    Console.WriteLine($"El precio promedio para el producto número {columna + 1} es ${promedios[columna]}");
}

