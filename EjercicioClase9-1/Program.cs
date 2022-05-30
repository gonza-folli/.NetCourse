Console.WriteLine("Ingrese el total de elementos del vector");
int cantidad = int.Parse(Console.ReadLine());

int[] vector = new int[cantidad];
Random aleatorio = new Random();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(100);
}

Console.WriteLine("Los elementos del vector son: ");

foreach(int i in vector)
{
    Console.WriteLine(i);
}

for (int i = 0; i < vector.Length /2 ; i++)
{
    int aux = vector[i];
    vector[i] = vector[vector.Length-i-1];
    vector[vector.Length-i-1] = aux;
}

Console.WriteLine("Los elementos INVERTIDOS del vector son: ");
foreach (int i in vector)
{
    Console.WriteLine(i);
}

Console.Read();
