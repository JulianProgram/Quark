using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        Presentador presentador;
        List<Libro> Libros;
        List<Socio> Socios;
        public Biblioteca(Presentador presentador)
        {
             Libros = new List<Libro>();
             Socios = new List<Socio>();
            this.presentador = presentador;
        }

        public List<Socio> Socios1 { get => Socios; set => Socios = value; }
        internal List<Libro> Libros1 { get => Libros; set => Libros = value; }

        public void agregarLibro(int codigo, string autor)
        {
            this.Libros1.Add(new Libro(codigo, autor));

            presentador.actualizarConsola("Libro agregado correctamente Codigo:" + codigo.ToString()+" Autor "+ autor);
        }
        public void agregarSocioClasico(Socio socio)
        {
            Socios1.Add(socio);
            
            presentador.actualizarConsola("Socio clásico agregado correctamente Nombre: "+socio.Nombre+" Apellido: "+socio.Apellido+" ID: " + socio.Id.ToString());
        }
        public void agregarSocioVip(Socio socio)
        {
            Socios1.Add(socio);

            presentador.actualizarConsola("Socio Vip agregado correctamente Nombre: " + socio.Nombre + " Apellido: " + socio.Apellido + " ID: " + socio.Id.ToString());
        }
        public void AgregarEjemplar(int Codigo, int edicion, string ubicacion)
        {
            BuscarLibro(Codigo).AgregarEjemplar(new Ejemplar(edicion, ubicacion));
            presentador.actualizarConsola("Ejemplar agregado correctamente Edicion:" + edicion.ToString() + "Al libro codigo:" + Codigo.ToString()) ;
        }
        public Libro BuscarLibro(int Codigo)
        {
            Libro retorno=null;
            foreach (Libro L in Libros1)
            {
                if (Codigo==L.Codigo1)
                {
                    retorno=L;
                }
            }
            return retorno;
        }

        public Socio BuscarSocio(int id)
        {
            Socio retorno = null;
            foreach (Socio S in Socios1)
            {
                if (id == S.Id)
                {
                    retorno = S;
                }
            }
            return retorno;
        }

        public List<string> ListarPrestamos()
        {
            List<string> listaRetorno = new List<string>();
            foreach (Socio socio in Socios)
            {
                //  listaRetorno.Add(socio.Id.ToString());
                foreach (Prestamo prestamo in socio.HistorialDePrestamos)
                {
                    listaRetorno.Add(" Socio: ");
                    listaRetorno.Add( " Nombre: "+prestamo.Socio.Nombre);
                    listaRetorno.Add(" Apellido: "+prestamo.Socio.Apellido);
                    listaRetorno.Add(" ID "+prestamo.Socio.Id.ToString());
                    listaRetorno.Add("Ejemplar prestado:");
                    listaRetorno.Add(" N° Edicion: "+prestamo.Ejemplar.Edicion1.ToString());
                    listaRetorno.Add("Fecha de retiro:");
                    listaRetorno.Add(prestamo.Fecha.ToString());
                    listaRetorno.Add("Fecha de devolución:");
                    if (prestamo.Devuelto())
                    {
                        listaRetorno.Add(prestamo.Devolucion.ToString());
                    }
                    else
                    {
                        listaRetorno.Add("Devolución pendiente");
                    }
                }
            }
            return listaRetorno;
        }
        public List<string> ListarEjemplares(int codigo)
        {
            Libro libro = BuscarLibro(codigo);
            List<string> listaRetorno = new List<string>();
            if (libro.ConsultarDisponible())
            {
                foreach (Ejemplar ejemplar in libro.EjemplaresDisponibles1)
                {
                    int i = 1;
                    listaRetorno.Add("Ejemplar número " + i.ToString());
                    listaRetorno.Add(" N° de Edición: "+ejemplar.Edicion1.ToString());
                    listaRetorno.Add(" Ubicación "+ejemplar.Ubicacion1);
                    i++;
                }
            }
            return listaRetorno;
        }

        public void DevolverEjemplar(int edicion, int Idsocio)
        {
            BuscarSocio(Idsocio).Devolver(BuscarSocio(Idsocio).BuscarEjemplarRetirado(edicion));
            
            presentador.actualizarConsola("Ejemplar: " + edicion.ToString() + "devuelto");
        }
    }
}
