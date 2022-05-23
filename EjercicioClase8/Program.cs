
int[,] numeros;
Console.WriteLine("Ingrese el tamaño de la matriz de 2 dimensiones");
Console.WriteLine("Tamaño de filas");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Tamaño de columnas");
int columnas = int.Parse(Console.ReadLine());

numeros = new int[filas, columnas];


//Obteniendo los limites de la matriz
int filasLength = numeros.GetUpperBound(0) + 1;
int columnasLength = numeros.GetUpperBound(1) + 1;

double[] promedios = new double[columnasLength];
double[] promediosFilas = new double[filasLength];

//Inserto todos los datos en la matriz
for (int i = 0; i < filasLength; i++)
{
    Console.WriteLine($"Ingrese los valores para la Fila {i + 1}");
    for (int j = 0; j < columnasLength; j++)
    {
        Console.WriteLine($"Valor {j + 1}");
        numeros[i,j] = int.Parse(Console.ReadLine());
    }
}

//recorro eje de filas y voy calculando el promedio de FILAS
for (int i = 0; i < filasLength; i++)
{
    Console.WriteLine($"Los valores para la Fila {i + 1}");
    double suma = 0;
    for (int j = 0; j < columnasLength; j++)
    {
        Console.Write($"Valor Fila {i+1}, Columna {j+1} : ");
        Console.WriteLine(numeros[i, j]);
        suma += numeros[i, j];
    }
    promediosFilas[i] = suma/ columnasLength;
}

//recorro en el eje contrario para calcular promedio de COLUMNAS
for (int i = 0; i < columnasLength; i++)
{
    double suma = 0;
    for (int j = 0; j < filasLength; j++)
    {
        suma += numeros[j, i];
    }
    promedios[i] = suma/ filasLength;
}
Console.WriteLine();
Console.WriteLine("______________________");
Console.WriteLine();
//Muestro promedio por Columna
for (int i = 0; i < promedios.Length; i++)
{
    Console.Write($"El promedio de la columna {i + 1} es : ");
    Console.WriteLine(promedios[i]);
}
Console.WriteLine();
Console.WriteLine("______________________");
Console.WriteLine();
//Muestro promedio por Fila
for (int i = 0; i < promediosFilas.Length; i++)
{
    Console.Write($"El promedio de la Fila {i + 1} es : ");
    Console.WriteLine(promediosFilas[i]);
}

Console.Read();