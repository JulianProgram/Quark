using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        Presentador presentador = new Presentador();
        public Form1()
        {
            InitializeComponent();
            this.presentador.Consola1 = Consola;
            groupBoxCrearSocio.Visible = false;
            grupboxAgregarEjemplar.Visible = false;
            groupBoxAgregarLibro.Visible = false;
            groupBoxDevolverEjemplar.Visible = false;
            groupBoxPrestamo.Visible = false;
        }
      
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkboxVIP.Checked)
            {
                presentador.crearSocioVip(nombre.Text, apellido.Text, int.Parse(id.Text));
                
                

            }
            else
            {
                presentador.crearSocioClasico(nombre.Text, apellido.Text, int.Parse(id.Text));
               
              

            }
           

          
        }

       

        private void BotonLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Códigolibro.TextLength>0 && AutorLibro.TextLength>0)
                {
                    presentador.agregarLibro(int.Parse(Códigolibro.Text), AutorLibro.Text);
                }
                else
                {
                    Consola.Items.Clear();
                    Consola.Items.Add("Debe ingresar obligatoriamente valores en ambos campos");
                }
                
            }
            catch (FormatException a)
            {
                Consola.Items.Clear();
                Consola.Items.Add("Debe ingresar obligatoriamente un número entero en el campo Código.");
            }

        }

     

        private void AgregarEjemplar_Click(object sender, EventArgs e)
        {
            presentador.AgregarEjemplar(int.Parse(CodigoEjemplar.Text), int.Parse(EdicionEjemplar.Text), UbicacionEjemplar.Text);
        }

      

        private void BotonPrestar_Click(object sender, EventArgs e)
        {
            presentador.Prestamo(int.Parse(PrestamoCodigo.Text), int.Parse(PrestamoSocio.Text));
        }

        private void HistorialPrestamos_Click(object sender, EventArgs e)
        {
            Consola.Items.Clear();
            foreach (string S in presentador.ListarPrestamos())
            {
                Consola.Items.Add(S);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar Ejemplares
            Consola.Items.Clear();
            if (presentador.ListarEjemplares(int.Parse(codigoMostrarEjemplares.Text))!=null)
            {
                foreach (string s in presentador.ListarEjemplares(int.Parse(codigoMostrarEjemplares.Text)))
                {
                    Consola.Items.Add(s);
                }
            }
            
        }

       

        private void DevolverEjemplar_Click(object sender, EventArgs e)
        {
            presentador.DevolverEjemplar(int.Parse(edicionEjemplarDevolver.Text), int.Parse(IdSocioDevolver.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarBox(groupBoxAgregarLibro);
        }
        private void MostrarBox(GroupBox box)
        {
            groupBoxCrearSocio.Visible = false;
            grupboxAgregarEjemplar.Visible = false;
            groupBoxAgregarLibro.Visible = false;
            groupBoxDevolverEjemplar.Visible = false;
            groupBoxPrestamo.Visible = false;
            box.Visible = true;
            
        }

        private void MenuCrearSocio_Click(object sender, EventArgs e)
        {
            MostrarBox(groupBoxCrearSocio);
        }

        private void MenuAgregarEjemplar_Click(object sender, EventArgs e)
        {
            MostrarBox(grupboxAgregarEjemplar);
        }

        private void MenuPrestar_Click(object sender, EventArgs e)
        {
            MostrarBox(groupBoxPrestamo);
           
        }

        private void MenuDevolver_Click(object sender, EventArgs e)
        {
            MostrarBox(groupBoxDevolverEjemplar);
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
