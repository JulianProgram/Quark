using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Prestamo
    {
        Ejemplar ejemplar;
        Socio socio;
        DateTime fecha;
        DateTime devolucion;
        public Prestamo(Ejemplar ejemplar, Socio socio)
        {
            this.Ejemplar = ejemplar;
            this.Socio = socio;
            this.Fecha = DateTime.Now;
            this.Devolucion = DateTime.MinValue;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Devolucion { get => devolucion; set => devolucion = value; }
        internal Ejemplar Ejemplar { get => ejemplar; set => ejemplar = value; }
        internal Socio Socio { get => socio; set => socio = value; }

        public void ActualizarFerchaDevolucion()
        {
            this.Devolucion = DateTime.Now;
            
        }
        public Boolean Devuelto()
        {
            return this.devolucion != DateTime.MinValue;
        }
    }
}
