using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaComunaRecorrida
    {
        public static List<ComunaRecorrida> listaRecorridos =
            new List<ComunaRecorrida>();

        public static bool Agregar(ComunaRecorrida op)
        {
            bool resultado = false;

            if (Validar(op))
            {
                ComunaRecorrida existe = Buscar(
                    op.Tramo.Carretera.Codigo,
                    op.Tramo.Numero,
                    op.Orden);

                if (existe == null)
                {
                    listaRecorridos.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(ComunaRecorrida op)
        {
            if (op == null || op.Tramo == null || op.Tramo.Carretera == null) return false;
            return Modificar(Buscar(op.Tramo.Carretera.Codigo, op.Tramo.Numero, op.Orden), op);
        }

        public static bool PuedeModificar(ComunaRecorrida original, ComunaRecorrida nuevo)
        {
            if (original == null || !listaRecorridos.Contains(original) || !Validar(nuevo)) return false;
            ComunaRecorrida existe = Buscar(nuevo.Tramo.Carretera.Codigo, nuevo.Tramo.Numero, nuevo.Orden);
            if (existe != null && existe != original) return false;
            var restantes = listaRecorridos.Where(x => x != original).Concat(new[] { nuevo });
            return ConservaExtremos(restantes);
        }

        private static bool ConservaExtremos(IEnumerable<ComunaRecorrida> recorridos)
        {
            foreach (ExtremoCarretera extremo in TListaExtremoCarretera.GetLista())
            {
                if (!ContienePunto(recorridos, extremo.Tramo, extremo.Comuna, extremo.Kilometro)) return false;
                if (extremo.TipoFinalizacion == "Confluencia con otra carretera" &&
                    !ContienePunto(recorridos, extremo.TramoDestino, extremo.ComunaDestino, extremo.KmDestino)) return false;
            }
            return true;
        }

        public static bool ContienePunto(IEnumerable<ComunaRecorrida> recorridos, Tramo tramo, Comuna comuna, double km)
        {
            if (tramo == null || tramo.Carretera == null || comuna == null) return false;
            return recorridos.Any(x => x.Tramo.Carretera.Codigo == tramo.Carretera.Codigo &&
                x.Tramo.Numero == tramo.Numero && x.Comuna.Codigo == comuna.Codigo &&
                km >= x.KmEntrada && km <= x.KmSalida);
        }

        public static bool Modificar(ComunaRecorrida original, ComunaRecorrida nuevo)
        {
            if (!PuedeModificar(original, nuevo)) return false;
            int pos = listaRecorridos.IndexOf(original);
            listaRecorridos[pos] = nuevo;
            return true;
        }

        public static bool Eliminar(int codigoCarretera,
            int numeroTramo, int orden)
        {
            bool resultado = false;

            ComunaRecorrida op = Buscar(
                codigoCarretera, numeroTramo, orden);

            if (op != null && ConservaExtremos(listaRecorridos.Where(x => x != op)))
            {
                listaRecorridos.Remove(op);
                resultado = true;
            }

            return resultado;
        }

        public static ComunaRecorrida Buscar(
            int codigoCarretera, int numeroTramo, int orden)
        {
            ComunaRecorrida resultado = listaRecorridos.FirstOrDefault(
                x => x.Tramo != null &&
                x.Tramo.Carretera != null &&
                x.Tramo.Carretera.Codigo == codigoCarretera &&
                x.Tramo.Numero == numeroTramo &&
                x.Orden == orden);

            return resultado;
        }

        public static bool Validar(ComunaRecorrida op)
        {
            bool resultado = false;

            if (op != null && op.Tramo != null &&
                op.Tramo.Carretera != null && op.Comuna != null)
            {
                Tramo tramo = TListaTramo.Buscar(
                    op.Tramo.Carretera.Codigo,
                    op.Tramo.Numero);

                Comuna comuna = TListaComuna.Buscar(op.Comuna.Codigo);

                if (tramo != null && comuna != null &&
                    op.Orden > 0 &&
                    !double.IsNaN(op.KmEntrada) &&
                    !double.IsNaN(op.KmSalida) &&
                    !double.IsInfinity(op.KmEntrada) &&
                    !double.IsInfinity(op.KmSalida) &&
                    op.KmEntrada >= tramo.KmInicial &&
                    op.KmSalida <= tramo.KmFinal &&
                    op.KmEntrada <= op.KmSalida)
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public static List<ComunaRecorrida> GetLista()
        {
            return listaRecorridos.ToList();
        }
    }
}
