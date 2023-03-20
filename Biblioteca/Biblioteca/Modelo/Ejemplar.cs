using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Ejemplar
    {
        int Edicion;
        string Ubicacion;// dudas

        public Ejemplar(int edicion, string ubicacion)
        {
            Edicion1 = edicion;
            Ubicacion1 = ubicacion;
        }

        public int Edicion1 { get => Edicion; set => Edicion = value; }
        public string Ubicacion1 { get => Ubicacion; set => Ubicacion = value; }
    }
}
