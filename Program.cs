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