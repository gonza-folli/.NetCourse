int[] misNumeros = new int[10];

for (int i = 0; i < 10; i++)
{
	Console.WriteLine($"Ingrese el {i + 1}º Número");
	misNumeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
int max = misNumeros[0];
int min = misNumeros[0];

foreach (int num in misNumeros)
{
	suma += num;
	if (num > max) max = num;
	if (num < min) min = num;
}

Console.WriteLine($"La suma de los numeros es {suma}");
Console.WriteLine($"El Mayor es {max}");
Console.WriteLine($"El Menor es {min}");
Console.WriteLine($"El promedio de los numeros es {suma / misNumeros.Length}");

Console.WriteLine($"Los números ingresados son:");

foreach (int num in misNumeros)
{
	Console.WriteLine(num);
}

Console.Read();