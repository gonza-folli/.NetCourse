using EjercicioClase14;

var baraja = new Baraja();
baraja.Barajar();
int validador = 0;


do
{
    Console.WriteLine("Seleccione una opción");
    Console.WriteLine("1- Barajar");
    Console.WriteLine("2- Mostrar siguiente carta");
    Console.WriteLine("3- Mostrar cartas disponibles");
    Console.WriteLine("4- Dar Cartas");
    Console.WriteLine("5- Mostrar cartas del montón");
    Console.WriteLine("6- Mostrar Baraja");
    Console.WriteLine("0- Salir del programa");

    validador = int.Parse(Console.ReadLine());

    switch (validador)
    {
        case 0:
            validador = -1;
            break;

        case 1:
            baraja.Barajar();
            break;

        case 2: 
            baraja.SiguienteCarta();
            break;

        case 3:
            baraja.CartasDisponibles();
            break;

        case 4:
            Console.WriteLine("Ingrese la cantidad de cartas a dar");
            int numeroADar = int.Parse(Console.ReadLine());
            baraja.DarCartas(numeroADar);
            break;

        case 5:
            baraja.CartasMonton();
            break;

        case 6:
            baraja.MostrarBaraja();
            break;
    }
}
while (validador != -1);

Console.WriteLine("Usted a salido del programa");


Console.Read();