using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    class Presentador
    {
        ListBox Consola;
        
        Biblioteca biblioteca;

        public ListBox Consola1 { get => Consola; set => Consola = value; }

        public Presentador()
        {
            biblioteca = new Biblioteca(this);
           
        }

        public void crearSocioVip(string nombre,string apellido,int id)
        {
            
            this.biblioteca.agregarSocioVip(new Vip(nombre, apellido, id));
        }
        public void crearSocioClasico(string nombre, string apellido, int id)
        {
            
            this.biblioteca.agregarSocioClasico(new Clasico(nombre, apellido, id));
        }
        public void agregarLibro(int codigo,string autor)
        {
            this.biblioteca.agregarLibro(codigo, autor);
        }
        public void agregarSocio(Socio socio)
        {
           // this.biblioteca.agregarSocio(socio);
        }

        public void AgregarEjemplar(int Codigo, int edicion, string ubicacion)
        {
            if (this.biblioteca.BuscarLibro(Codigo)!=null)
            {
                this.biblioteca.AgregarEjemplar(Codigo, edicion, ubicacion);
            }
            else
            {
                actualizarConsola("No se ha encontrado el libro con codigo: " + Codigo.ToString());
            }
            
            
        }

        public void Prestamo(int codigolibro,int idsocio)
        {
            Libro libro= this.biblioteca.BuscarLibro(codigolibro);
            if (libro.ConsultarDisponible())
            {
                Socio socio = this.biblioteca.BuscarSocio(idsocio);
                if (socio!=null)
                {
                    if (socio.HayCupo())
                    {
                        if (libro.ConsultarDisponible())
                        {
                            socio.PedirPrestado(libro.Prestar());// agrego el ejemplar a los ejemplares prestados del socio y creo prestamo
                            actualizarConsola("Prestamo generado correctamente Libro:" + codigolibro.ToString() + "al Socio:" + idsocio.ToString());
                        }
                        else
                        {
                            actualizarConsola("Este libro no contiene ejemplares disponibles");
                        }
                       
                    }
                    else
                    {
                        actualizarConsola("Este socio llego a su máximo de prestamos disponibles");
                    }
                }
                else
                {
                    actualizarConsola("El socio es incorrecto");
                }
               



            }
            else
            {
                actualizarConsola("No hay ejemplares disponibles");
            }
            
        }
        public List<string> ListarPrestamos()
        {
            return this.biblioteca.ListarPrestamos();
        }

        public List<string> ListarEjemplares(int codigo)
        {
            if (this.biblioteca.BuscarLibro(codigo).ConsultarDisponible())
            {
                return this.biblioteca.ListarEjemplares(codigo);
            }
            else
            {
                actualizarConsola("No hay ejemplares disponibles");
                return null;
            }
          
            
        }
        public void actualizarConsola(string text)
        {
            this.Consola.Items.Clear();
            
            
            this.Consola.Items.Add(text);
            
        }
        public void DevolverEjemplar(int edicion,int Idsocio)
        {
            this.biblioteca.DevolverEjemplar(edicion, Idsocio);
            
        }
    }
}
