// See https://aka.ms/new-console-template for more information

int[] numeros = new int[10];
int minimo = 0, maximo = 0, total = 0;
float promedio = 0;


for (int i = 0; i < numeros.Length; i++)
{
    Console.Write("Por favor ingrese un número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Clear();

for (int i = 0; i< numeros.Length; i++)
{
    Console.WriteLine($"El número ingresado en la posición {i + 1} es {numeros[i]}");
    if (i == 0)
    {
        minimo = numeros[i];
        maximo = numeros[i];
    }
    else
    {
        if (numeros[i] < minimo)
        {
            minimo = numeros[i];
        }
        if (numeros[i] > maximo)
        {
            maximo = numeros[i];
        }
    }
    total += numeros[i];
}
Console.WriteLine();
Console.WriteLine($"La suma total de los números ingresados es {total}");
Console.WriteLine($"El número mayor de todos es el {maximo}");
Console.WriteLine($"El número menor de todos es el {minimo}");
promedio = (float) total / numeros.Length;
Console.WriteLine($"El promedio de los números ingresados es {promedio}");



