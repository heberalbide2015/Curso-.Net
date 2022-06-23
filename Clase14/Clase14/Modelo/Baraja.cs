using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14.Modelo
{
    public class Baraja
    {
        public List<Carta> Cartas { get; set; }
        public List<Carta> Mazo { get; set; }

        public Baraja()
        {
            Cartas = new List<Carta>();
            Mazo = new List<Carta>();

            string[] palos = { "Espada", "Basto", "Oro", "Copa" };
            Carta carta;
            foreach (string palo in palos) {

                for (int nro = 1; nro < 11; nro++)
                {
                    if (nro < 8)
                    {
                        carta = new Carta(palo, nro);
                    }
                    else
                    {
                        carta = new Carta(palo, nro + 2);
                    }
                    Cartas.Add(carta);
                }

            }

        }

        public void Barajar()
        {
            Random random = new Random();
            int posicionAuxiliar = 0;
            Carta cartaAuxiliar;
            for (int nro = 1; nro < 11; nro++)
            {
                for (int posicion = 0; posicion < Cartas.Count; posicion++)
                {
                    posicionAuxiliar = random.Next(0, Cartas.Count);
                    cartaAuxiliar = Cartas[posicionAuxiliar];
                    Cartas[posicionAuxiliar] = Cartas[posicion];
                    Cartas[posicion] = cartaAuxiliar;
                }

            }

        }

        public Carta SiguienteCarta()
        {
            Carta carta = null;
            if (Cartas.Count > 0)
            {
                carta = Cartas[Cartas.Count - 1];
                Cartas.RemoveAt(Cartas.Count - 1);
                Mazo.Add(carta);
            }
            return carta;
        }

        public int CartasDisponibles() {
            return Cartas.Count;
        }
        public List<Carta> DarCartas(int cantidad)
        {
            List<Carta> mano = new List<Carta>();
            Carta carta;
            if(cantidad <= Cartas.Count)
            {
                for(int i = 0; i < cantidad; i++)
                {
                    carta = Cartas[Cartas.Count - 1];
                    Cartas.RemoveAt(Cartas.Count - 1);
                    Mazo.Add(carta);
                    mano.Add(carta);

                }
            }
            return mano;
        }

        public void CartasMonton()
        {
            if(Mazo.Count > 0)
            {
                Console.WriteLine("Las cartas que ya han salido son:");
                for (int indice = Mazo.Count - 1; indice >= 0; indice--)
                {
                    Console.WriteLine(Mazo[indice]);
                }
            }
            else
            {
                Console.WriteLine("Todavía no ha salido ninguna carta");
            }
            
        }

        public void MostrarBaraja()
        {
            if(Cartas.Count > 0)
            {
                Console.WriteLine("Las cartas que quedan en la baraja son:");
                for (int indice = Cartas.Count - 1; indice >= 0; indice--)
                {
                    Console.WriteLine(Cartas[indice]);
                }
            }
            else
            {
                Console.WriteLine("No quedan más cartas en la baraja");
            }
            
        }

        
    }
}
