int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int intentos = 0;
int numeroElegido = -1;

while(numeroSecreto != numeroElegido)
{
    Console.WriteLine("Ingrese el número que piense es el secreto");
    numeroElegido = int.Parse(Console.ReadLine());
    if (numeroElegido > numeroSecreto)
    {
        Console.WriteLine("el número ingresado es MAYOR al secreto");
        intentos++;
    } else if (numeroElegido < numeroSecreto)
    {
        Console.WriteLine("el número ingresado es MENOR al secreto");
        intentos++;
    }
}
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
Console.WriteLine($"Lo has logrado en {intentos+1} intentos!!");

Console.Read();

