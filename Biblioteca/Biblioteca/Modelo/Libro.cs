using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        int Codigo;
        string Autor;
        List<Ejemplar> EjemplaresDisponibles;

        public Libro(int codigo, string autor)
        {
            Codigo1 = codigo;
            Autor1 = autor;
            
            EjemplaresDisponibles1 = new List<Ejemplar>();
        }

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        internal List<Ejemplar> EjemplaresDisponibles1 { get => EjemplaresDisponibles; set => EjemplaresDisponibles = value; }

        public void AgregarEjemplar(Ejemplar ejemplar)
        {
            this.EjemplaresDisponibles1.Add(ejemplar);
        }
        
        public Boolean ConsultarDisponible()
        {
            return this.EjemplaresDisponibles1.Count> 0;
        }

        public Ejemplar Prestar()// tal vez deberia interactuar con el prestamo
        {
            Ejemplar retorno;
            retorno = EjemplaresDisponibles1.First();
            EjemplaresDisponibles1.Remove(retorno);
            return retorno;
           
        }

        public void ReingresoEjemplar(Ejemplar ejemplar)
        {
            EjemplaresDisponibles1.Add(ejemplar);
        }
    }
}
