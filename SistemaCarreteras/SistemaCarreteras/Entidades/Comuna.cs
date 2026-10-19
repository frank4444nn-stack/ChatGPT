using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class Comuna
    {
        private int codigo;
        private string nombre;
        private string canton;
        private string provincia;

        public Comuna()
        {
        }

        public Comuna(int codigo, string nombre, string canton, string provincia)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.canton = canton;
            this.provincia = provincia;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Canton
        {
            get { return canton; }
            set { canton = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
