using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase14
{
    public class Baraja : Carta
    {
       public List<Carta> MiBaraja { get; set; }
       public List<Carta> CartasRepartidas { get; set; }
       public Baraja ()
        {
            List<Carta> estaBaraja = new List<Carta>();

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
            string[] palos = new string[] { "Espada", "Basto", "Oro", "Copa" };

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < palos.Length; j++)
                {
                    Carta carta = new Carta(numeros[i], palos[j]);
                    estaBaraja.Add(carta);
                }
            }
            CartasRepartidas = new List<Carta>();
            MiBaraja = estaBaraja;
        }


        public void Barajar()
        {
            Random random = new Random();
            int n = MiBaraja.Count;

            for (int i = MiBaraja.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Carta value = MiBaraja[rnd];
                MiBaraja[rnd] = MiBaraja[i];
                MiBaraja[i] = value;
            }
            Console.WriteLine("Las cartas han sido barajadas");
        }

        public void SiguienteCarta()
        {
            if (MiBaraja.Count == 0)
            {
                Console.WriteLine("No hay mas cartas");
            }
            else
            {
                Console.WriteLine($"La siguiente carta es el {MiBaraja[0].Numero} de {MiBaraja[0].Palo}");
                CartasRepartidas.Add(MiBaraja[0]);
                MiBaraja.Remove(MiBaraja[0]);

            }
        }

        public void CartasDisponibles()
        {
            Console.WriteLine($"La cantidad de cartas por repartir es de {MiBaraja.Count}");
        }

        public void DarCartas(int cantidad)
        {
            if (MiBaraja.Count < cantidad)
            {
                Console.WriteLine("La cantidad introducida es mayor a la cantidad de cartas restantes");
            } else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Se repartió la carta {MiBaraja[0].Numero} de {MiBaraja[0].Palo}");
                    CartasRepartidas.Add(MiBaraja[0]);
                    MiBaraja.Remove(MiBaraja[0]);
                }
            }
        }
        public void CartasMonton()
        {
            if (CartasRepartidas.Count == 0)
            {
                Console.WriteLine("Mo ha salido ninguna carta");
            } else
            {
                foreach (Carta carta in CartasRepartidas)
                {
                    Console.WriteLine($"La carta es el {carta.Numero} de {carta.Palo}");
                }
            }
        }

        public void MostrarBaraja()
        {
            Console.WriteLine("Las cartas que restan por reparir aún son:");
            foreach (Carta carta in MiBaraja)
            {
                Console.WriteLine($"El {carta.Numero} de {carta.Palo}");
            }
        }

    }
}
