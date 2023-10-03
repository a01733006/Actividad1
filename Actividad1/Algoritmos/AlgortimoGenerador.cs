using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Algoritmos
{
    public class AlgortimoGenerador
    {
        public double CalcularMedia (List<Viaje> ListaViajes)
        {
            double media = 0, suma = 0;
            foreach(Viaje viaje in ListaViajes)
            {
                suma = suma + viaje.Costo; 
            }
            if (ListaViajes.Count > 0)
            {
                media = suma / ListaViajes.Count;
            }
           
            return media;


        }

    }
}
