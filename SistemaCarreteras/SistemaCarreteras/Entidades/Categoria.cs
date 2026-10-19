using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class Categoria
    {
        private int codigo;
        private string nombre;

        public Categoria()
        {
        }

        public Categoria(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
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

        public override string ToString()
        {
            return Nombre;
        }
    }
}
