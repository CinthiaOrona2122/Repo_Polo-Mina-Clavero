/* 1) Crear una matriz de dos dimensiones de tipo int llamada numeros.
 * 2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla.
 * 3) Declarar un vector de tipo double llamado promedios
   double promedios = 0;
 * 4) Recorrer la matriz para su carga con elementos de tipo int
 * 5) Recorrer la matriz para mostrar cada valor de la matriz
 * 6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
 * 7) Mostrar los promedios recorriendo el vector promedios
*/

Console.Clear();

Console.WriteLine("=======================================");
Console.WriteLine("Ingrese la cantidad de filas");

Console.WriteLine();
Console.WriteLine("=======================================");

//Determinar el tamaño de cada columna, fila ingresados por pantalla.
Console.Write("Ingrese el numero de indices del vector horizontal: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingrese el numero de indices del vector vertical: ");
int fil = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=======================================");

int[,] numeros = new int[fil, col];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Declarar el vector promedios
double[] promedio = new double[lengthColumnas];

//Cargar los valores de la matriz.
for (int c = 0; c < lengthColumnas; c++)
{
    Console.WriteLine();

    Console.WriteLine($"Columna N° {c + 1}: ");

    for (int m = 0; m < lengthFilas; m++)
    {
        Console.Write($"Cargue el numero en la fila N° {m + 1}: ");
        numeros[fil, col] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");


//Mostrar los valores de la matriz.
for (int c = 0; c < lengthColumnas; c++)
{

    Console.WriteLine();
    Console.WriteLine($"Numeros de la columna N°: {c + 1}: ");

    for (int m = 0; m < lengthFilas; m++)
    {
        Console.Write($"Valor de la fila N° {m + 1}: ");
        Console.WriteLine(numeros[fil, col]);
    }
}

for (int c = 0; c < lengthColumnas; c++)
{
    for (int m = 0; m < lengthFilas; m++)
    {
        promedio[c] += numeros[m, c];
    }
    promedio[c] = promedio[c] / lengthFilas;
}


for (int c = 0; c < lengthColumnas; c++)
{
    Console.WriteLine();
    Console.WriteLine($"El promedio de la columna N° {c + 1} es: {promedio[c]}");
}

Console.WriteLine("Press any key to finish");
Console.ReadKey();
