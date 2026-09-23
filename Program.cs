//funcion de imprimir
static void imprimirNotas (int[] notas)
{
    for (int i = 0 ; i<notas.Length ; i++)
{
    System.Console.WriteLine(notas [i]);
}

}


int[] notas = {15 , 18 , 12 , 17 , 20};

// Imprimir las notas
imprimirNotas(notas);


//calcular el promedio de las notas


static double promedioNotas(int[] notas)
{
    int suma = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        suma += notas[i];
    }

    double promedio = (double)suma / notas.Length;

    return promedio;
}

double promedio = promedioNotas(notas);
Console.WriteLine($"El promedio es: {promedio}");
