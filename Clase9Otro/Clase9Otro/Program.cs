// See https://aka.ms/new-console-template for more information

int[,] carton = new int[3, 9];
int[] cantFilas = new int[3];
int ceros = 0;
int posicion = 0;
int nro1 = 0;
int nro2 = 0;
int nro3 = 0;

for (int i = 0; i < 9; i++)
{
    /////// GENERO EL O LOS NUMEROS
    nro1 = new Random().Next(i * 10, i * 10 + 9);
    do
    {
        nro2 = new Random().Next(i * 10, i * 10 + 9);
    } while (nro2 == nro1);

    do
    {
        nro3 = new Random().Next(i * 10, i * 10 + 9);
    } while (nro3 == nro1 || nro3 == nro2);

    //ORDENO Y UBICO LOS NÚMEROS EN LA COLUMNA
    int aux = 0;
    if (nro1 > nro2 || nro2 > nro3)
    {
        if (nro1 > nro2)
        {
            aux = nro1;
            nro1 = nro2;
            nro2 = aux;
        }
        if (nro2 > nro3)
        {
            aux = nro2;
            nro2 = nro3;
            nro3 = aux;
        }
    }
    carton[0, i] = nro1;
    carton[1, i] = nro2;
    carton[2, i] = nro3;

}

// COLOCO CEROS EN LAS DOS PRIMERAS FILAS
for (int i = 0; i<2; i++)
{
    do
    {
        posicion = new Random().Next(0, 9);
        if (carton[i, posicion] != 0)
        {
            ceros++;
            carton[i, posicion] = 0;
        }

    } while (ceros < 4);
    ceros = 0;
}

// VERIFICO SI ES POSIBLE GENERAR EL CARTON

for (int i = 0; i < 9; i++)
{
    if (carton[0, i] != 0 || carton[1, i] != 0)
    {
        ceros++;
    }
}

if(ceros < 5)
{
    Console.WriteLine("No es posible generar el carton, intente nuevamente");
}
else
{
    ceros = 0;
    do
    {
        posicion = new Random().Next(0, 9);
        if (carton[2, posicion] != 0)
        {
            ceros++;
            carton[2, posicion] = 0;
        }

    } while (ceros < 4);

    // IMPRIMO EL CARTON
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if (carton[i, j] != 0)
            {
                if (j == 0)
                {

                    Console.Write("0" + carton[i, j]);
                }
                else
                {

                    Console.Write(carton[i, j]);
                }

            }
            else
            {
                Console.Write("##");
            }


            // Console.Write(carton[i, j]);
            if (i < 8)
            {
                Console.Write("   ");
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

}