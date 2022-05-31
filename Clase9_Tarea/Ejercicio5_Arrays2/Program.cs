/*1)      Pedir al usuario la longitud de un vector
 *2)      Crear el vector del tamaño ingresado.
 *3)      Llenar el mismo con datos aleatorios
 *4)      Mostrar el vector por pantalla
 *5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; 
 *  el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. 
 *  En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, 
 *  el vector debe quedar así: 50, 40, 30, 20, 10.  
 *6)      Mostrar el vector nuevamente. 
 */

Console.Clear();

//1
Console.WriteLine("Ingrese el tamaño deseado para el listado:");
int n = Convert.ToInt32(Console.ReadLine());

//2
int[] miVector = new int[n];

//3
Random aleatorio = new Random();

//4
for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(100);
}

var contador = 0;
foreach (var i in miVector)
{
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}

//5 con función Reverse()
Console.WriteLine();
Console.WriteLine("La lista dada vuelta queda: ");
//Console.WriteLine();
//Array.Reverse(miVector);

//5 con ciclo For
Console.WriteLine();

int aux = 0;
int largo = miVector.Length;
for (int i = 0; i < largo /2; i++)
{
    aux = miVector[i];
    miVector[i] = miVector[largo - 1 - i];
    miVector[largo - 1 - i] = aux;
}


//6
foreach (var i in miVector)
{
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}

Console.ReadKey();