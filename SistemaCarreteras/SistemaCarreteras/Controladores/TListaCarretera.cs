using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaCarretera
    {
        public static List<Carretera> listaCarreteras = new List<Carretera>();

        public static bool Agregar(Carretera op)
        {
            bool resultado = false;

            if (op != null && op.Codigo > 0 &&
                !string.IsNullOrWhiteSpace(op.Nombre) &&
                op.Categoria != null)
            {
                Carretera existe = Buscar(op.Codigo);

                bool categoriaExiste = TListaCategoria.listaCategorias.Any(
                    x => x.Codigo == op.Categoria.Codigo);

                if (existe == null && categoriaExiste)
                {
                    listaCarreteras.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(Carretera op)
        {
            if (op == null || !(op.Codigo > 0 && !string.IsNullOrWhiteSpace(op.Nombre))) return false;
            Carretera actual = Buscar(op.Codigo);
            if (actual == null) return false;
            if (op.Categoria == null || TListaCategoria.Buscar(op.Categoria.Codigo) == null) return false;
            actual.Nombre = op.Nombre;
            actual.Categoria = TListaCategoria.Buscar(op.Categoria.Codigo);
            return true;
        }

        public static bool Eliminar(int codigo)
        {
            bool resultado = false;

            Carretera op = Buscar(codigo);

            if (op != null)
            {
                bool tieneTramos = TListaTramo.listaTramos.Any(
                    x => x.Carretera != null &&
                    x.Carretera.Codigo == codigo);

                bool tieneExtremos = TListaExtremoCarretera.listaExtremos.Any(
                    x => (x.Carretera != null &&
                          x.Carretera.Codigo == codigo) ||
                         (x.CarreteraDestino != null &&
                          x.CarreteraDestino.Codigo == codigo));

                if (!tieneTramos && !tieneExtremos)
                {
                    listaCarreteras.Remove(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static Carretera Buscar(int codigo)
        {
            Carretera resultado = listaCarreteras.FirstOrDefault(
                x => x.Codigo == codigo);

            return resultado;
        }

        public static List<Carretera> GetLista()
        {
            return listaCarreteras.ToList();
        }
    }
}