using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class Carretera
    {
        private int codigo;
        private string nombre;
        private Categoria categoria;

        public Carretera()
        {
        }

        public Carretera(int codigo, string nombre, Categoria categoria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.categoria = categoria;
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

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string NombreCategoria
        {
            get
            {
                string resultado = "";

                if (categoria != null)
                {
                    resultado = categoria.Nombre;
                }

                return resultado;
            }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
