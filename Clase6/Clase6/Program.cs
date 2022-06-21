int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int intentos = 0;
Console.Clear();
int numero;

Console.WriteLine("Intente adivinar el número que eligió la computadora");
Console.WriteLine();

do
{
    
    Console.Write("Ingrese un número del 1 al 20: ");
    numero = int.Parse(Console.ReadLine());
    intentos++;
    if (numero < 0 || numero > 20)
    {
        Console.WriteLine("El número ingresado está fuera del rango pedido");
    }
    else
    {
        if (numero > numeroSecreto)
        {
            Console.WriteLine("El número ingresado es muy grande, intente nuevamente");
            Console.WriteLine();
        }
        else
        {
            if (numero < numeroSecreto)
            {
                Console.WriteLine("El número ingresado es muy chico, intente nuevamente");
                Console.WriteLine();
            }
        }

    }

} while (numero != numeroSecreto);
Console.WriteLine();
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era {numeroSecreto}");
Console.WriteLine($"Lo has logrado  en {intentos} intentos!!");
