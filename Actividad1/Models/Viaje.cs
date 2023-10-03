using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Viaje
    {
        public string IdOrigen { get; set; }
        public string IdDestino { get; set; }
        public long LatitudOrigen { get; set; }
        public long LongitudOrigen { get;set; }
        public long LatitudDestino { get;set; }
        public long LongitudDestino { get; set; }
        public int CantidadDemanda { get; set; }
        public double Costo { get; set; }
        public DateTime FechaHoraLlegada { get; set; }

        //Constuctor
        public Viaje () { }
        public Viaje (string idOrigen, string idDestino, long latitudOrigen, long longitudOrigen, long latitudDestino, long longitudDestino, int cantidadDemanda, double costo, DateTime fechaHoraLlegada)
        {
            //Metodos
            IdOrigen = idOrigen;
            IdDestino = idDestino;
            LatitudOrigen = latitudOrigen;
            LongitudOrigen = longitudOrigen;
            LatitudDestino = latitudDestino;
            LongitudDestino = longitudDestino;
            CantidadDemanda = cantidadDemanda;
            Costo = costo;
            FechaHoraLlegada = fechaHoraLlegada;
        }
    }
}
