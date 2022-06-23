using Clase14.Modelo;

Console.Clear();
int opcion = 0;
int cantidad = 0;
List<Carta> cartas;
Baraja baraja = new Baraja();

do
{
    Console.WriteLine("Bienvenido al juego de cartas españolas");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    Console.WriteLine();
    Console.Write("Escoja una opción del menú: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            baraja.Barajar();
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine(baraja.SiguienteCarta());
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            Console.WriteLine($"Quedan en la baraja {baraja.CartasDisponibles()} cartas disponibles");
            Console.WriteLine();
            Console.WriteLine(); 
            break;
        case 4:
            Console.WriteLine();
            Console.Write("Por favor indique la cantidad de cartas que desea recibir: ");
            cantidad = int.Parse(Console.ReadLine());
            cartas = baraja.DarCartas(cantidad);
            Console.WriteLine();
            if (cartas.Count <= 0)
            {
                Console.WriteLine("No hay suficientes cartas disponibles");
            }
            else
            {
                foreach (Carta c in cartas)
                {
                    Console.WriteLine(c);
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            break;

        case 5:
            Console.WriteLine();
            baraja.CartasMonton();
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine();
            baraja.MostrarBaraja();
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine();
            Console.WriteLine("Esperamos que haya disfrutado de la experiencia");
            Console.WriteLine();
            Console.WriteLine();
            
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Opción incorrecta");
            Console.WriteLine();
            Console.WriteLine();
            break;
    }

}while(opcion != 7);


