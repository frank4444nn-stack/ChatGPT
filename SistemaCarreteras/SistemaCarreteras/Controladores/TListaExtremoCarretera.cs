using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaExtremoCarretera
    {
        public static List<ExtremoCarretera> listaExtremos =
            new List<ExtremoCarretera>();

        public static bool Agregar(ExtremoCarretera op)
        {
            bool resultado = false;

            if (Validar(op))
            {
                ExtremoCarretera existe = Buscar(
                    op.Carretera.Codigo, op.TipoExtremo);

                if (existe == null)
                {
                    listaExtremos.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(ExtremoCarretera op)
        {
            bool resultado = false;

            if (Validar(op))
            {
                int pos = listaExtremos.FindIndex(
                    x => x.Carretera != null &&
                    x.Carretera.Codigo == op.Carretera.Codigo &&
                    string.Equals(x.TipoExtremo, op.TipoExtremo,
                        StringComparison.OrdinalIgnoreCase));

                if (pos >= 0)
                {
                    listaExtremos[pos] = op;
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Eliminar(int codigoCarretera,
            string tipoExtremo)
        {
            bool resultado = false;

            ExtremoCarretera op = Buscar(
                codigoCarretera, tipoExtremo);

            if (op != null)
            {
                listaExtremos.Remove(op);
                resultado = true;
            }

            return resultado;
        }

        public static ExtremoCarretera Buscar(
            int codigoCarretera, string tipoExtremo)
        {
            ExtremoCarretera resultado = listaExtremos.FirstOrDefault(
                x => x.Carretera != null &&
                x.Carretera.Codigo == codigoCarretera &&
                string.Equals(x.TipoExtremo, tipoExtremo,
                    StringComparison.OrdinalIgnoreCase));

            return resultado;
        }

        public static bool Validar(ExtremoCarretera op)
        {
            bool resultado = false;

            if (op != null && op.Carretera != null &&
                op.Tramo != null && op.Comuna != null)
            {
                bool tipoValido =
                    op.TipoExtremo == "Inicio" ||
                    op.TipoExtremo == "Final";

                bool finalizacionValida =
                    op.TipoFinalizacion == "Finalización física" ||
                    op.TipoFinalizacion == "Confluencia con otra carretera";

                Carretera carretera = TListaCarretera.Buscar(
                    op.Carretera.Codigo);

                Tramo tramo = TListaTramo.Buscar(
                    op.Carretera.Codigo, op.Tramo.Numero);

                Comuna comuna = TListaComuna.Buscar(op.Comuna.Codigo);

                if (tipoValido && finalizacionValida &&
                    carretera != null && tramo != null &&
                    comuna != null &&
                    op.Tramo.Carretera != null && op.Tramo.Carretera.Codigo == carretera.Codigo &&
                    EsLimite(op, tramo) &&
                    TListaComunaRecorrida.ContienePunto(TListaComunaRecorrida.GetLista(), tramo, comuna, op.Kilometro) &&
                    !double.IsNaN(op.Kilometro) &&
                    !double.IsInfinity(op.Kilometro) &&
                    op.Kilometro >= tramo.KmInicial &&
                    op.Kilometro <= tramo.KmFinal)
                {
                    if (op.TipoFinalizacion == "Finalización física")
                    {
                        resultado = true;
                    }
                    else
                    {
                        if (op.CarreteraDestino != null &&
                            op.TramoDestino != null &&
                            op.ComunaDestino != null)
                        {
                            Carretera destino = TListaCarretera.Buscar(
                                op.CarreteraDestino.Codigo);

                            Tramo tramoDestino = TListaTramo.Buscar(
                                op.CarreteraDestino.Codigo,
                                op.TramoDestino.Numero);

                            Comuna comunaDestino = TListaComuna.Buscar(
                                op.ComunaDestino.Codigo);

                            if (destino != null &&
                                tramoDestino != null &&
                                comunaDestino != null &&
                                op.TramoDestino.Carretera != null && op.TramoDestino.Carretera.Codigo == destino.Codigo &&
                                !string.IsNullOrWhiteSpace(op.Observacion) &&
                                TListaComunaRecorrida.ContienePunto(TListaComunaRecorrida.GetLista(), tramoDestino, comunaDestino, op.KmDestino) &&
                                destino.Codigo != carretera.Codigo &&
                                !double.IsNaN(op.KmDestino) &&
                                !double.IsInfinity(op.KmDestino) &&
                                op.KmDestino >= tramoDestino.KmInicial &&
                                op.KmDestino <= tramoDestino.KmFinal)
                            {
                                resultado = true;
                            }
                        }
                    }
                }
            }

            return resultado;
        }

        private static bool EsLimite(ExtremoCarretera op, Tramo tramo)
        {
            var tramos = TListaTramo.GetLista().Where(x => x.Carretera.Codigo == op.Carretera.Codigo).ToList();
            if (tramos.Count == 0) return false;
            if (op.TipoExtremo == "Inicio")
                return op.Kilometro == tramo.KmInicial && op.Kilometro == tramos.Min(x => x.KmInicial);
            return op.Kilometro == tramo.KmFinal && op.Kilometro == tramos.Max(x => x.KmFinal);
        }

        public static List<ExtremoCarretera> GetLista()
        {
            return listaExtremos.ToList();
        }
    }
}