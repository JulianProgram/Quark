
namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxVIP = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCrearSocio = new System.Windows.Forms.GroupBox();
            this.groupBoxAgregarLibro = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.codigoMostrarEjemplares = new System.Windows.Forms.TextBox();
            this.BotonLibro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Códigolibro = new System.Windows.Forms.TextBox();
            this.AutorLibro = new System.Windows.Forms.TextBox();
            this.grupboxAgregarEjemplar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CodigoEjemplar = new System.Windows.Forms.TextBox();
            this.AgregarEjemplar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UbicacionEjemplar = new System.Windows.Forms.TextBox();
            this.EdicionEjemplar = new System.Windows.Forms.TextBox();
            this.groupBoxPrestamo = new System.Windows.Forms.GroupBox();
            this.HistorialPrestamos = new System.Windows.Forms.Button();
            this.BotonPrestar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PrestamoSocio = new System.Windows.Forms.TextBox();
            this.PrestamoCodigo = new System.Windows.Forms.TextBox();
            this.Consola = new System.Windows.Forms.ListBox();
            this.groupBoxDevolverEjemplar = new System.Windows.Forms.GroupBox();
            this.DevolverEjemplar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.IdSocioDevolver = new System.Windows.Forms.TextBox();
            this.edicionEjemplarDevolver = new System.Windows.Forms.TextBox();
            this.MenuAgregarLibro = new System.Windows.Forms.Button();
            this.MenuCrearSocio = new System.Windows.Forms.Button();
            this.MenuAgregarEjemplar = new System.Windows.Forms.Button();
            this.MenuPrestar = new System.Windows.Forms.Button();
            this.MenuDevolver = new System.Windows.Forms.Button();
            this.MenuSalir = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxCrearSocio.SuspendLayout();
            this.groupBoxAgregarLibro.SuspendLayout();
            this.grupboxAgregarEjemplar.SuspendLayout();
            this.groupBoxPrestamo.SuspendLayout();
            this.groupBoxDevolverEjemplar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // checkboxVIP
            // 
            this.checkboxVIP.AutoSize = true;
            this.checkboxVIP.Location = new System.Drawing.Point(59, 92);
            this.checkboxVIP.Name = "checkboxVIP";
            this.checkboxVIP.Size = new System.Drawing.Size(43, 17);
            this.checkboxVIP.TabIndex = 1;
            this.checkboxVIP.Text = "VIP";
            this.checkboxVIP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(59, 20);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 4;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(59, 44);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(59, 66);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear socio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxCrearSocio
            // 
            this.groupBoxCrearSocio.Controls.Add(this.label4);
            this.groupBoxCrearSocio.Controls.Add(this.checkboxVIP);
            this.groupBoxCrearSocio.Controls.Add(this.button1);
            this.groupBoxCrearSocio.Controls.Add(this.label5);
            this.groupBoxCrearSocio.Controls.Add(this.id);
            this.groupBoxCrearSocio.Controls.Add(this.label6);
            this.groupBoxCrearSocio.Controls.Add(this.apellido);
            this.groupBoxCrearSocio.Controls.Add(this.nombre);
            this.groupBoxCrearSocio.Location = new System.Drawing.Point(212, 74);
            this.groupBoxCrearSocio.Name = "groupBoxCrearSocio";
            this.groupBoxCrearSocio.Size = new System.Drawing.Size(200, 158);
            this.groupBoxCrearSocio.TabIndex = 9;
            this.groupBoxCrearSocio.TabStop = false;
            this.groupBoxCrearSocio.Text = "Crear Socios";
            // 
            // groupBoxAgregarLibro
            // 
            this.groupBoxAgregarLibro.Controls.Add(this.button2);
            this.groupBoxAgregarLibro.Controls.Add(this.label14);
            this.groupBoxAgregarLibro.Controls.Add(this.codigoMostrarEjemplares);
            this.groupBoxAgregarLibro.Controls.Add(this.BotonLibro);
            this.groupBoxAgregarLibro.Controls.Add(this.label8);
            this.groupBoxAgregarLibro.Controls.Add(this.label7);
            this.groupBoxAgregarLibro.Controls.Add(this.Códigolibro);
            this.groupBoxAgregarLibro.Controls.Add(this.AutorLibro);
            this.groupBoxAgregarLibro.Location = new System.Drawing.Point(220, 58);
            this.groupBoxAgregarLibro.Name = "groupBoxAgregarLibro";
            this.groupBoxAgregarLibro.Size = new System.Drawing.Size(200, 195);
            this.groupBoxAgregarLibro.TabIndex = 10;
            this.groupBoxAgregarLibro.TabStop = false;
            this.groupBoxAgregarLibro.Text = "Agregar Libros";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mostrar ejemplares";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Código Libro";
            // 
            // codigoMostrarEjemplares
            // 
            this.codigoMostrarEjemplares.Location = new System.Drawing.Point(82, 130);
            this.codigoMostrarEjemplares.Name = "codigoMostrarEjemplares";
            this.codigoMostrarEjemplares.Size = new System.Drawing.Size(100, 20);
            this.codigoMostrarEjemplares.TabIndex = 9;
            // 
            // BotonLibro
            // 
            this.BotonLibro.Location = new System.Drawing.Point(93, 92);
            this.BotonLibro.Name = "BotonLibro";
            this.BotonLibro.Size = new System.Drawing.Size(75, 23);
            this.BotonLibro.TabIndex = 8;
            this.BotonLibro.Text = "Crear Libro";
            this.BotonLibro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BotonLibro.UseVisualStyleBackColor = true;
            this.BotonLibro.Click += new System.EventHandler(this.BotonLibro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Autor";
            // 
            // Códigolibro
            // 
            this.Códigolibro.Location = new System.Drawing.Point(93, 56);
            this.Códigolibro.Name = "Códigolibro";
            this.Códigolibro.Size = new System.Drawing.Size(100, 20);
            this.Códigolibro.TabIndex = 1;
            // 
            // AutorLibro
            // 
            this.AutorLibro.Location = new System.Drawing.Point(93, 29);
            this.AutorLibro.Name = "AutorLibro";
            this.AutorLibro.Size = new System.Drawing.Size(100, 20);
            this.AutorLibro.TabIndex = 0;
            // 
            // grupboxAgregarEjemplar
            // 
            this.grupboxAgregarEjemplar.Controls.Add(this.label11);
            this.grupboxAgregarEjemplar.Controls.Add(this.CodigoEjemplar);
            this.grupboxAgregarEjemplar.Controls.Add(this.AgregarEjemplar);
            this.grupboxAgregarEjemplar.Controls.Add(this.label9);
            this.grupboxAgregarEjemplar.Controls.Add(this.label10);
            this.grupboxAgregarEjemplar.Controls.Add(this.UbicacionEjemplar);
            this.grupboxAgregarEjemplar.Controls.Add(this.EdicionEjemplar);
            this.grupboxAgregarEjemplar.Location = new System.Drawing.Point(212, 74);
            this.grupboxAgregarEjemplar.Name = "grupboxAgregarEjemplar";
            this.grupboxAgregarEjemplar.Size = new System.Drawing.Size(200, 163);
            this.grupboxAgregarEjemplar.TabIndex = 11;
            this.grupboxAgregarEjemplar.TabStop = false;
            this.grupboxAgregarEjemplar.Text = "Agregar Ejemplar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Código del libro";
            // 
            // CodigoEjemplar
            // 
            this.CodigoEjemplar.Location = new System.Drawing.Point(94, 88);
            this.CodigoEjemplar.Name = "CodigoEjemplar";
            this.CodigoEjemplar.Size = new System.Drawing.Size(100, 20);
            this.CodigoEjemplar.TabIndex = 9;
            // 
            // AgregarEjemplar
            // 
            this.AgregarEjemplar.Location = new System.Drawing.Point(93, 134);
            this.AgregarEjemplar.Name = "AgregarEjemplar";
            this.AgregarEjemplar.Size = new System.Drawing.Size(75, 23);
            this.AgregarEjemplar.TabIndex = 8;
            this.AgregarEjemplar.Text = "Agregar";
            this.AgregarEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AgregarEjemplar.UseVisualStyleBackColor = true;
            this.AgregarEjemplar.Click += new System.EventHandler(this.AgregarEjemplar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ubicación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "N° Edición";
            // 
            // UbicacionEjemplar
            // 
            this.UbicacionEjemplar.Location = new System.Drawing.Point(93, 56);
            this.UbicacionEjemplar.Name = "UbicacionEjemplar";
            this.UbicacionEjemplar.Size = new System.Drawing.Size(100, 20);
            this.UbicacionEjemplar.TabIndex = 1;
            // 
            // EdicionEjemplar
            // 
            this.EdicionEjemplar.Location = new System.Drawing.Point(93, 29);
            this.EdicionEjemplar.Name = "EdicionEjemplar";
            this.EdicionEjemplar.Size = new System.Drawing.Size(100, 20);
            this.EdicionEjemplar.TabIndex = 0;
            // 
            // groupBoxPrestamo
            // 
            this.groupBoxPrestamo.Controls.Add(this.HistorialPrestamos);
            this.groupBoxPrestamo.Controls.Add(this.BotonPrestar);
            this.groupBoxPrestamo.Controls.Add(this.label12);
            this.groupBoxPrestamo.Controls.Add(this.label13);
            this.groupBoxPrestamo.Controls.Add(this.PrestamoSocio);
            this.groupBoxPrestamo.Controls.Add(this.PrestamoCodigo);
            this.groupBoxPrestamo.Location = new System.Drawing.Point(226, 55);
            this.groupBoxPrestamo.Name = "groupBoxPrestamo";
            this.groupBoxPrestamo.Size = new System.Drawing.Size(200, 192);
            this.groupBoxPrestamo.TabIndex = 11;
            this.groupBoxPrestamo.TabStop = false;
            this.groupBoxPrestamo.Text = "Prestamo";
            // 
            // HistorialPrestamos
            // 
            this.HistorialPrestamos.Location = new System.Drawing.Point(16, 138);
            this.HistorialPrestamos.Name = "HistorialPrestamos";
            this.HistorialPrestamos.Size = new System.Drawing.Size(161, 23);
            this.HistorialPrestamos.TabIndex = 9;
            this.HistorialPrestamos.Text = "Mostrar historial de prestamos";
            this.HistorialPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.HistorialPrestamos.UseVisualStyleBackColor = true;
            this.HistorialPrestamos.Click += new System.EventHandler(this.HistorialPrestamos_Click);
            // 
            // BotonPrestar
            // 
            this.BotonPrestar.Location = new System.Drawing.Point(93, 92);
            this.BotonPrestar.Name = "BotonPrestar";
            this.BotonPrestar.Size = new System.Drawing.Size(75, 23);
            this.BotonPrestar.TabIndex = 8;
            this.BotonPrestar.Text = "Prestar";
            this.BotonPrestar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BotonPrestar.UseVisualStyleBackColor = true;
            this.BotonPrestar.Click += new System.EventHandler(this.BotonPrestar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "ID Socio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Código del libro";
            // 
            // PrestamoSocio
            // 
            this.PrestamoSocio.Location = new System.Drawing.Point(93, 56);
            this.PrestamoSocio.Name = "PrestamoSocio";
            this.PrestamoSocio.Size = new System.Drawing.Size(100, 20);
            this.PrestamoSocio.TabIndex = 1;
            // 
            // PrestamoCodigo
            // 
            this.PrestamoCodigo.Location = new System.Drawing.Point(93, 29);
            this.PrestamoCodigo.Name = "PrestamoCodigo";
            this.PrestamoCodigo.Size = new System.Drawing.Size(100, 20);
            this.PrestamoCodigo.TabIndex = 0;
            // 
            // Consola
            // 
            this.Consola.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Consola.FormattingEnabled = true;
            this.Consola.Location = new System.Drawing.Point(12, 283);
            this.Consola.Name = "Consola";
            this.Consola.Size = new System.Drawing.Size(466, 147);
            this.Consola.TabIndex = 12;
            // 
            // groupBoxDevolverEjemplar
            // 
            this.groupBoxDevolverEjemplar.Controls.Add(this.DevolverEjemplar);
            this.groupBoxDevolverEjemplar.Controls.Add(this.label15);
            this.groupBoxDevolverEjemplar.Controls.Add(this.label16);
            this.groupBoxDevolverEjemplar.Controls.Add(this.IdSocioDevolver);
            this.groupBoxDevolverEjemplar.Controls.Add(this.edicionEjemplarDevolver);
            this.groupBoxDevolverEjemplar.Location = new System.Drawing.Point(220, 75);
            this.groupBoxDevolverEjemplar.Name = "groupBoxDevolverEjemplar";
            this.groupBoxDevolverEjemplar.Size = new System.Drawing.Size(263, 130);
            this.groupBoxDevolverEjemplar.TabIndex = 12;
            this.groupBoxDevolverEjemplar.TabStop = false;
            this.groupBoxDevolverEjemplar.Text = "Devolver Ejemplar";
            // 
            // DevolverEjemplar
            // 
            this.DevolverEjemplar.Location = new System.Drawing.Point(93, 92);
            this.DevolverEjemplar.Name = "DevolverEjemplar";
            this.DevolverEjemplar.Size = new System.Drawing.Size(75, 23);
            this.DevolverEjemplar.TabIndex = 8;
            this.DevolverEjemplar.Text = "Devolver";
            this.DevolverEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DevolverEjemplar.UseVisualStyleBackColor = true;
            this.DevolverEjemplar.Click += new System.EventHandler(this.DevolverEjemplar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "ID Socio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "N° Edicion del ejemplar ";
            // 
            // IdSocioDevolver
            // 
            this.IdSocioDevolver.Location = new System.Drawing.Point(131, 56);
            this.IdSocioDevolver.Name = "IdSocioDevolver";
            this.IdSocioDevolver.Size = new System.Drawing.Size(100, 20);
            this.IdSocioDevolver.TabIndex = 1;
            // 
            // edicionEjemplarDevolver
            // 
            this.edicionEjemplarDevolver.Location = new System.Drawing.Point(131, 29);
            this.edicionEjemplarDevolver.Name = "edicionEjemplarDevolver";
            this.edicionEjemplarDevolver.Size = new System.Drawing.Size(100, 20);
            this.edicionEjemplarDevolver.TabIndex = 0;
            // 
            // MenuAgregarLibro
            // 
            this.MenuAgregarLibro.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.MenuAgregarLibro.Location = new System.Drawing.Point(49, 58);
            this.MenuAgregarLibro.Name = "MenuAgregarLibro";
            this.MenuAgregarLibro.Size = new System.Drawing.Size(132, 23);
            this.MenuAgregarLibro.TabIndex = 10;
            this.MenuAgregarLibro.Text = "Agregar Libro";
            this.MenuAgregarLibro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAgregarLibro.UseVisualStyleBackColor = true;
            this.MenuAgregarLibro.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuCrearSocio
            // 
            this.MenuCrearSocio.Location = new System.Drawing.Point(49, 90);
            this.MenuCrearSocio.Name = "MenuCrearSocio";
            this.MenuCrearSocio.Size = new System.Drawing.Size(132, 23);
            this.MenuCrearSocio.TabIndex = 13;
            this.MenuCrearSocio.Text = "Crear Socio";
            this.MenuCrearSocio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuCrearSocio.UseVisualStyleBackColor = true;
            this.MenuCrearSocio.Click += new System.EventHandler(this.MenuCrearSocio_Click);
            // 
            // MenuAgregarEjemplar
            // 
            this.MenuAgregarEjemplar.Location = new System.Drawing.Point(49, 125);
            this.MenuAgregarEjemplar.Name = "MenuAgregarEjemplar";
            this.MenuAgregarEjemplar.Size = new System.Drawing.Size(132, 23);
            this.MenuAgregarEjemplar.TabIndex = 14;
            this.MenuAgregarEjemplar.Text = "Agregar Ejemplar";
            this.MenuAgregarEjemplar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuAgregarEjemplar.UseVisualStyleBackColor = true;
            this.MenuAgregarEjemplar.Click += new System.EventHandler(this.MenuAgregarEjemplar_Click);
            // 
            // MenuPrestar
            // 
            this.MenuPrestar.Location = new System.Drawing.Point(49, 155);
            this.MenuPrestar.Name = "MenuPrestar";
            this.MenuPrestar.Size = new System.Drawing.Size(132, 23);
            this.MenuPrestar.TabIndex = 15;
            this.MenuPrestar.Text = "Realizar Prestamo";
            this.MenuPrestar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuPrestar.UseVisualStyleBackColor = true;
            this.MenuPrestar.Click += new System.EventHandler(this.MenuPrestar_Click);
            // 
            // MenuDevolver
            // 
            this.MenuDevolver.Location = new System.Drawing.Point(49, 184);
            this.MenuDevolver.Name = "MenuDevolver";
            this.MenuDevolver.Size = new System.Drawing.Size(132, 23);
            this.MenuDevolver.TabIndex = 16;
            this.MenuDevolver.Text = "Realizar Devolución";
            this.MenuDevolver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuDevolver.UseVisualStyleBackColor = true;
            this.MenuDevolver.Click += new System.EventHandler(this.MenuDevolver_Click);
            // 
            // MenuSalir
            // 
            this.MenuSalir.Location = new System.Drawing.Point(72, 218);
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(75, 23);
            this.MenuSalir.TabIndex = 18;
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MenuSalir.UseVisualStyleBackColor = true;
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 37);
            this.label17.TabIndex = 19;
            this.label17.Text = "BIBLIOTECA";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(505, 457);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MenuSalir);
            this.Controls.Add(this.MenuDevolver);
            this.Controls.Add(this.MenuPrestar);
            this.Controls.Add(this.MenuAgregarEjemplar);
            this.Controls.Add(this.groupBoxCrearSocio);
            this.Controls.Add(this.MenuCrearSocio);
            this.Controls.Add(this.MenuAgregarLibro);
            this.Controls.Add(this.groupBoxDevolverEjemplar);
            this.Controls.Add(this.groupBoxPrestamo);
            this.Controls.Add(this.Consola);
            this.Controls.Add(this.grupboxAgregarEjemplar);
            this.Controls.Add(this.groupBoxAgregarLibro);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxCrearSocio.ResumeLayout(false);
            this.groupBoxCrearSocio.PerformLayout();
            this.groupBoxAgregarLibro.ResumeLayout(false);
            this.groupBoxAgregarLibro.PerformLayout();
            this.grupboxAgregarEjemplar.ResumeLayout(false);
            this.grupboxAgregarEjemplar.PerformLayout();
            this.groupBoxPrestamo.ResumeLayout(false);
            this.groupBoxPrestamo.PerformLayout();
            this.groupBoxDevolverEjemplar.ResumeLayout(false);
            this.groupBoxDevolverEjemplar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxVIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxCrearSocio;
        private System.Windows.Forms.GroupBox groupBoxAgregarLibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Códigolibro;
        private System.Windows.Forms.TextBox AutorLibro;
        private System.Windows.Forms.Button BotonLibro;
        private System.Windows.Forms.GroupBox grupboxAgregarEjemplar;
        private System.Windows.Forms.Button AgregarEjemplar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UbicacionEjemplar;
        private System.Windows.Forms.TextBox EdicionEjemplar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CodigoEjemplar;
        private System.Windows.Forms.GroupBox groupBoxPrestamo;
        private System.Windows.Forms.Button BotonPrestar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PrestamoSocio;
        private System.Windows.Forms.TextBox PrestamoCodigo;
        private System.Windows.Forms.Button HistorialPrestamos;
        private System.Windows.Forms.ListBox Consola;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox codigoMostrarEjemplares;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxDevolverEjemplar;
        private System.Windows.Forms.Button DevolverEjemplar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IdSocioDevolver;
        private System.Windows.Forms.TextBox edicionEjemplarDevolver;
        private System.Windows.Forms.Button MenuAgregarLibro;
        private System.Windows.Forms.Button MenuCrearSocio;
        private System.Windows.Forms.Button MenuAgregarEjemplar;
        private System.Windows.Forms.Button MenuPrestar;
        private System.Windows.Forms.Button MenuDevolver;
        private System.Windows.Forms.Button MenuSalir;
        private System.Windows.Forms.Label label17;
    }
}

