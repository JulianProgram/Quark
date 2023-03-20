using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Vip : Socio
    {
         private  int cuota;

         private int cantMax;

        public Vip(string nombre,string apellido,int id)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id = id;
            this.EjemplaresRetirados = new List<Ejemplar>();
            this.HistorialDePrestamos = new List<Prestamo>();
            this.cantMax = 3;
        }

        public override Boolean HayCupo()
        {
            return this.EjemplaresRetirados.Count < cantMax;

        }

        public override void PedirPrestado(Ejemplar ejemplar)
        {
            
            
                this.EjemplaresRetirados.Add(ejemplar);
                this.HistorialDePrestamos.Add(new Prestamo(ejemplar, this));
            
           
            
        }

        public override void Devolver(Ejemplar ejemplar)
        {
            this.EjemplaresRetirados.Remove(ejemplar);
            foreach (Prestamo P in HistorialDePrestamos)//recorro la lista de prestamos buscando por el mismo ejemplar y le actualizo la fecha de devolucion.
            {
                if (P.Ejemplar==ejemplar)
                {
                    P.ActualizarFerchaDevolucion();
                }
            }
        }
        public override Ejemplar BuscarEjemplarRetirado(int edicion)
        {
            Ejemplar retorno=null;
            foreach (Ejemplar ej in EjemplaresRetirados)
            {
                if (ej.Edicion1==edicion)
                {
                    retorno=ej;
                }
                
            }
            return retorno;
        }


    }

}
