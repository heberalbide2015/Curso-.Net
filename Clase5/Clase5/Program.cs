string respuesta = "S";

while(respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();

    Console.WriteLine($"¡Hola, {nombre}!");

    Console.Write("¿Desea continuar? S para Sí, N para No: ");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N") {
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opción no válida");
}
