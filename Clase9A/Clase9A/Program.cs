// See https://aka.ms/new-console-template for more information
Console.Write("Por favor ingrese el tamaño del vector con el que desea trabajar: ");
int tamanio = int.Parse(Console.ReadLine());
int[] array = new int[tamanio];

for (int i = 0; i < tamanio; i++)
{
    array[i] = new Random().Next(1, 21);
}
Console.WriteLine();
Console.WriteLine("El array generado cuenta con los siguientes elementos: ");

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if(i < array.Length - 1)
    {
        Console.Write(" - ");
    } else
    {
        Console.WriteLine();
    }
}
int aux = 0;
for(int i = 0; i < array.Length /2; i++)
{
    aux = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = array[i];
    array[i] = aux;
}
Console.WriteLine();
Console.WriteLine("El array invertido queda de la siguiente forma:");

foreach(var item in array)
{
    Console.WriteLine(item);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(" - ");
    }
    else
    {
        Console.WriteLine();
    }

}