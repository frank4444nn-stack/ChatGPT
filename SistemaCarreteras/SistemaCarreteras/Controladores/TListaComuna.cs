using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaComuna
    {
        public static List<Comuna> listaComunas = new List<Comuna>();

        public static bool Agregar(Comuna op)
        {
            bool resultado = false;

            if (op != null && op.Codigo > 0 &&
                !string.IsNullOrWhiteSpace(op.Nombre) &&
                !string.IsNullOrWhiteSpace(op.Canton) &&
                !string.IsNullOrWhiteSpace(op.Provincia))
            {
                Comuna existe = Buscar(op.Codigo);

                if (existe == null)
                {
                    listaComunas.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(Comuna op)
        {
            if (op == null || !(op.Codigo > 0 && !string.IsNullOrWhiteSpace(op.Nombre) && !string.IsNullOrWhiteSpace(op.Canton) && !string.IsNullOrWhiteSpace(op.Provincia))) return false;
            Comuna actual = Buscar(op.Codigo);
            if (actual == null) return false;
            actual.Nombre = op.Nombre;
            actual.Canton = op.Canton;
            actual.Provincia = op.Provincia;
            return true;
        }

        public static bool Eliminar(int codigo)
        {
            bool resultado = false;

            Comuna op = Buscar(codigo);

            if (op != null)
            {
                bool tieneRecorridos = TListaComunaRecorrida.listaRecorridos.Any(
                    x => x.Comuna != null &&
                    x.Comuna.Codigo == codigo);

                bool tieneExtremos = TListaExtremoCarretera.listaExtremos.Any(
                    x => (x.Comuna != null &&
                          x.Comuna.Codigo == codigo) ||
                         (x.ComunaDestino != null &&
                          x.ComunaDestino.Codigo == codigo));

                if (!tieneRecorridos && !tieneExtremos)
                {
                    listaComunas.Remove(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static Comuna Buscar(int codigo)
        {
            Comuna resultado = listaComunas.FirstOrDefault(
                x => x.Codigo == codigo);

            return resultado;
        }

        public static List<Comuna> GetLista()
        {
            return listaComunas.ToList();
        }
    }
}