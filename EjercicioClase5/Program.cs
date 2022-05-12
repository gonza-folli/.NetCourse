var respuesta = "S";

while (respuesta?.ToUpper() == "S")
{
    Console.WriteLine("Ingrese un nombre");
    var nombre = Console.ReadLine();

    Console.WriteLine($"Hola {nombre}!!!");

    Console.WriteLine("Desea continuar? S/N");
    respuesta = Console.ReadLine();

}
if (respuesta?.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}