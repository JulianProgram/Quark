using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   abstract class Socio
    {
        private string nombre;
        private string apellido;
        private int id;
        protected List<Ejemplar> EjemplaresRetirados;
        private List<Prestamo> historialDePrestamos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        public List<Prestamo> HistorialDePrestamos { get => historialDePrestamos; set => historialDePrestamos = value; }

        public abstract Boolean HayCupo();
        public abstract void PedirPrestado(Ejemplar ejemplar);
        public abstract void Devolver(Ejemplar ejemplar);

        public abstract Ejemplar BuscarEjemplarRetirado(int edicion);

       

       
    }
   
    
}
