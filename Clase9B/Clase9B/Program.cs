// See https://aka.ms/new-console-template for more information

int[,] tarjeta = new int[3, 9];
int[] cantFilas = new int[3];

// Columnas con un solo elemento
int col1 = new Random().Next(0, 9);
int col2, col3;
do
{
    col2 = new Random().Next(0, 9);
} while (col1 == col2);

do
{
    col3 = new Random().Next(0, 9);
} while (col1 == col3 || col2 == col3);


int nro1 = 0;
int nro2 = 0;

for (int i = 0; i < 9; i++)
{
    /////// GENERO EL O LOS NUMEROS
    do
    {
        nro1 = new Random().Next(i * 10, i * 10 + 9);
    } while (nro1 == 0);

    if (i != col1 && i != col2 && i != col3)
    {

        do
        {
            nro2 = new Random().Next(i * 10, i * 10 + 9);
        } while (nro2 == 0 || nro1 == nro2);

    }

    //UBICO EL O LOS NÚMEROS
    int ubicacion1 = 0;
    int ubicacion2 = 0;
    Console.WriteLine($"{cantFilas[0]}-{cantFilas[1]}-{cantFilas[2]}");
    Console.WriteLine($"Estoy ubicando el número 1 de la columna {i}");
    do
    {
        ubicacion1 = new Random().Next(0, 3);
    } while (cantFilas[ubicacion1] == 5);
    cantFilas[ubicacion1] += 1;
    if (i > 6)
    {
        Console.WriteLine(ubicacion1);
    }
    if (i != col1 && i != col2 && i != col3)
    {
        Console.WriteLine($"{cantFilas[0]}-{cantFilas[1]}-{cantFilas[2]}");

        Console.WriteLine($"Estoy ubicando el número 2 de la columna {i}");
        do
        {
            ubicacion2 = new Random().Next(0, 3);
            if (i > 6)
            {
                Console.Write(ubicacion2);
            }
        } while (cantFilas[ubicacion2] == 5 || ubicacion1 == ubicacion2);
        cantFilas[ubicacion2] += 1;
        if (nro1 < nro2)
        {
            tarjeta[ubicacion1, i] = nro1;
            tarjeta[ubicacion2, i] = nro2;
        }
        else
        {
            tarjeta[ubicacion1, i] = nro2;
            tarjeta[ubicacion2, i] = nro1;
        }

    }
    else
    {
        tarjeta[ubicacion1, i] = nro1;
    }



}

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 9; j++)
    {
        Console.Write(tarjeta[i, j]);
        if(i<8)
        {
            Console.Write(" - ");
        }
        else {
            Console.WriteLine();
                }
    }
    Console.WriteLine();
}

