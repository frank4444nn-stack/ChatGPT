using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaCategoria
    {
        public static List<Categoria> listaCategorias = new List<Categoria>();

        public static bool Agregar(Categoria op)
        {
            bool resultado = false;

            if (op != null && op.Codigo > 0 &&
                !string.IsNullOrWhiteSpace(op.Nombre))
            {
                Categoria existe = Buscar(op.Codigo);

                if (existe == null)
                {
                    listaCategorias.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(Categoria op)
        {
            if (op == null || !(op.Codigo > 0 && !string.IsNullOrWhiteSpace(op.Nombre))) return false;
            Categoria actual = Buscar(op.Codigo);
            if (actual == null) return false;
            actual.Nombre = op.Nombre;
            return true;
        }

        public static bool Eliminar(int codigo)
        {
            bool resultado = false;

            Categoria op = Buscar(codigo);

            if (op != null)
            {
                bool utilizada = TListaCarretera.listaCarreteras.Any(
                    x => x.Categoria != null &&
                    x.Categoria.Codigo == codigo);

                if (!utilizada)
                {
                    listaCategorias.Remove(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static Categoria Buscar(int codigo)
        {
            Categoria resultado = listaCategorias.FirstOrDefault(
                x => x.Codigo == codigo);

            return resultado;
        }

        public static List<Categoria> GetLista()
        {
            return listaCategorias.ToList();
        }
    }
}