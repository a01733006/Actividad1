using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Algoritmos
{
    public class AlgortimoGenerador
    {
        List<Viaje> lista = new List<Viaje>(); 
        public List<Viaje> GenerarLista(int dimension)
        {
            List<Viaje> Lista = new List<Viaje>();

            for (int i = 0; i < dimension; i++)
            {
                Viaje viaje = new Viaje();
                viaje.Costo = i;

                Lista.Add(viaje);
            }
            return Lista;
        }
        public double CalcularMedia(List<Viaje> listaViajes)
        {
            double media = 0, suma = 0;
            foreach (Viaje viaje in listaViajes)
            {
                suma = suma + viaje.Costo;
            }
            if (listaViajes.Count > 0)
            {
                media = suma / listaViajes.Count;
            }

            return media;
        }
        public double AlgoritmoMedia (int totalValores)
        {
            double media = 0;
            List<Viaje> Lista = GenerarLista(totalValores);
            media = CalcularMedia(Lista);
            return media;
        }

        public bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(numero));

            for (int i = 3; i <= boundary; i += 2)
                if (numero % i == 0)
                    return false;

            return true;
        }

        public List<int> AlgoritmoCongruenciaLineal(int a, int m, int c, int x0, int totalValores)
        {
            List<int> listaSalida = new List<int>();
            if (!EsPrimo(m))
            {
                MessageBox.Show("m debe ser un número primo");
           
                return listaSalida;
            }
            listaSalida.Add(x0);
            
            for (int i = 0; i < totalValores; i++)
            {
                int x = (a * listaSalida[i] + c) % m;
                listaSalida.Add(x);

                if (x == x0)
                {
                    MessageBox.Show("Ya se repitió el número");

                    return listaSalida;
                }

            }
            return listaSalida;
        }

    }
}
