using EjercicioClase13.Models;

var billetera1 = new Billetera(5, 32, 3, 8, 7, 5, 9);
var billetera2 = new Billetera(5, 8, 7, 4, 9, 6, 8);

Console.WriteLine($"El total de la billetera 1 es de {billetera1.Total()}");
Console.WriteLine($"El total de la billetera 2 es de {billetera2.Total()}");

var billetera3 = new Billetera();
billetera3 = billetera3.Combinar(billetera1, billetera2);

Console.WriteLine($"El total de la nueva billetera es de {billetera3.Total()}");