int[,] carton = new int[3, 9];

int filasLength = carton.GetUpperBound(0) + 1;
int columnasLength = carton.GetUpperBound(1) + 1;

Random aleatorio = new Random(); // numero aleatorio


int contador = 0;

int[] arrayNumeros = new int[15];

int min = 0;
int min2 = 0;

while (contador < 15)
{
    if (contador < 9)
    {
        int nuevoNumero = aleatorio.Next(min, min + 10);
        //para evitar numeros repeditos
        if (arrayNumeros.Contains(nuevoNumero))
        {
            nuevoNumero = aleatorio.Next(min, min + 10);
            if (arrayNumeros.Contains(nuevoNumero))
            {
                nuevoNumero = aleatorio.Next(min, min + 10);
            }
        }
        arrayNumeros[contador] = nuevoNumero;

        min += 10;

    }
    else
    {
        int nuevoNumero = aleatorio.Next(min2, min2 + 15);
        //para evitar numeros repeditos
        if (arrayNumeros.Contains(nuevoNumero))
        {
            nuevoNumero = aleatorio.Next(min2, min2 + 15);
            if (arrayNumeros.Contains(nuevoNumero))
            {
                nuevoNumero = aleatorio.Next(min2, min2 + 15);
            }
        }
        arrayNumeros[contador] = nuevoNumero;
        min2 += 15;
    }

    contador++;
}

for (int i = 0; i < arrayNumeros.Length; i++)
{
    Console.WriteLine(arrayNumeros[i]);
}

//arrayNumeros = arrayNumeros.OrderBy(x => aleatorio.Next()).ToArray();

int fila = 0;

for (int i = 0; i < arrayNumeros.Length; i++)
{

    if (i % 5 == 0 && i != 0)
    {
        fila++;
    }

    int column = arrayNumeros[i] / 10;
    //Console.WriteLine(arrayNumeros[i]);

    if (carton[fila, column] > 0)
    {
        Console.Write("Faltan agregar: ");
        Console.WriteLine(arrayNumeros[i]);
        if (fila == 2)
        {
            carton[fila - 2, column] = arrayNumeros[i]; // seria la ultima fila ocupada por lo que lo llevo a la primera
        }
        else
        {
            carton[fila + 1, column] = arrayNumeros[i]; // si esta ocupada dicha fila, lo paso a la siguiente
        }
    }
    else
    {
        carton[fila, column] = arrayNumeros[i];
    }
}



for (int i = 0; i < filasLength; i++)
{
    int cantidad = 0;
    Console.Write($"Fila {i + 1}:   ");
    for (int j = 0; j < columnasLength; j++)
    {
        if (carton[i, j] == 0)
        {
            Console.Write("  xx  ");
        }
        else
        {
            Console.Write($"  {carton[i, j]}  ");
            cantidad++;
        }
    }
    Console.WriteLine();
    Console.WriteLine(cantidad);
}
Console.Read();