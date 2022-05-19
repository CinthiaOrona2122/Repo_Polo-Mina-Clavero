
int[] numero = new int[10];
int contador = 0;
int numMayor = 0;
int numMenor = 0;
int promedio = 0;

//guardar numeros en los indices
Console.WriteLine($"El array tiene {numero.Length} indices.");

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine(i+1 + " : " + "Ingrese un numero:");
    numero[i] = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    Console.WriteLine($"Ultimo numero ingresado es: {numero[i]}");
}

//sumar todos los indices
for (int i = 0; i < numero.Length; i++)
{
    contador += numero[i];
    promedio = (contador / numero.Length);
}
Console.WriteLine();
Console.WriteLine($"El promedio del array es: {promedio}");
Console.WriteLine();
Console.WriteLine($"El valor de la suma es: {contador}");
Console.WriteLine();
Console.Write($"Los valores del array son: ");

//mostrar todos los indices ingresados
for (int i = 0; i < numero.Length; i++)
{
    Console.Write(numero[i]+ ", ");
}

//el mayor y menor ...
for (int i = 0; i < numero.Length; i++)
{
    if(i == 1 - 1)
    {
        numMayor = numero[i];
        numMenor = numero[i];
    }
    else if(numero[i] > numMayor)
    {
        numMayor = numero[i];
    }
    else
    {
        numMenor = numero[i];
    }

}
Console.WriteLine($"El numero mayor es: {numMayor}");
Console.WriteLine($"El numero menor es: {numMenor}");
Console.ReadKey();