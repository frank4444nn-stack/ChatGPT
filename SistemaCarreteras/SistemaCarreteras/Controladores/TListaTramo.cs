using SistemaCarreteras.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Controladores
{
    public class TListaTramo
    {
        public static List<Tramo> listaTramos = new List<Tramo>();

        public static bool Agregar(Tramo op)
        {
            bool resultado = false;

            if (Validar(op))
            {
                Tramo existe = Buscar(
                    op.Carretera.Codigo, op.Numero);

                if (existe == null && !TListaExtremoCarretera.GetLista().Any(x =>
                    x.Carretera.Codigo == op.Carretera.Codigo &&
                    ((x.TipoExtremo == "Inicio" && op.KmInicial < x.Kilometro) ||
                     (x.TipoExtremo == "Final" && op.KmFinal > x.Kilometro))))
                {
                    listaTramos.Add(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static bool Modificar(Tramo op)
        {
            if (!Validar(op)) return false;
            Tramo actual = Buscar(op.Carretera.Codigo, op.Numero);
            if (actual == null) return false;
            bool fuera = TListaComunaRecorrida.GetLista().Any(x =>
                x.Tramo.Carretera.Codigo == op.Carretera.Codigo && x.Tramo.Numero == op.Numero &&
                (x.KmEntrada < op.KmInicial || x.KmSalida > op.KmFinal));
            if (fuera) return false;
            // Evaluate proposed boundaries before mutating the canonical tramo.
            double minimo = listaTramos.Where(x => x.Carretera.Codigo == op.Carretera.Codigo)
                .Min(x => x == actual ? op.KmInicial : x.KmInicial);
            double maximo = listaTramos.Where(x => x.Carretera.Codigo == op.Carretera.Codigo)
                .Max(x => x == actual ? op.KmFinal : x.KmFinal);
            foreach (ExtremoCarretera x in TListaExtremoCarretera.GetLista())
            {
                if (x.Carretera.Codigo == op.Carretera.Codigo)
                {
                    if (x.TipoExtremo == "Inicio" && (x.Kilometro != minimo ||
                        (x.Tramo.Numero == op.Numero && x.Kilometro != op.KmInicial))) return false;
                    if (x.TipoExtremo == "Final" && (x.Kilometro != maximo ||
                        (x.Tramo.Numero == op.Numero && x.Kilometro != op.KmFinal))) return false;
                }
                if (x.TramoDestino != null && x.TramoDestino.Carretera.Codigo == op.Carretera.Codigo &&
                    x.TramoDestino.Numero == op.Numero && (x.KmDestino < op.KmInicial || x.KmDestino > op.KmFinal)) return false;
            }
            actual.KmInicial = op.KmInicial;
            actual.KmFinal = op.KmFinal;
            return true;
        }

        public static bool Eliminar(int codigoCarretera, int numero)
        {
            bool resultado = false;

            Tramo op = Buscar(codigoCarretera, numero);

            if (op != null)
            {
                bool tieneRecorridos = TListaComunaRecorrida.listaRecorridos.Any(
                    x => x.Tramo != null &&
                    x.Tramo.Carretera != null &&
                    x.Tramo.Carretera.Codigo == codigoCarretera &&
                    x.Tramo.Numero == numero);

                bool tieneExtremos = TListaExtremoCarretera.listaExtremos.Any(
                    x => (x.Tramo != null &&
                          x.Tramo.Carretera != null &&
                          x.Tramo.Carretera.Codigo == codigoCarretera &&
                          x.Tramo.Numero == numero) ||
                         (x.TramoDestino != null &&
                          x.TramoDestino.Carretera != null &&
                          x.TramoDestino.Carretera.Codigo == codigoCarretera &&
                          x.TramoDestino.Numero == numero));

                if (!tieneRecorridos && !tieneExtremos)
                {
                    listaTramos.Remove(op);
                    resultado = true;
                }
            }

            return resultado;
        }

        public static Tramo Buscar(int codigoCarretera, int numero)
        {
            Tramo resultado = listaTramos.FirstOrDefault(
                x => x.Carretera != null &&
                x.Carretera.Codigo == codigoCarretera &&
                x.Numero == numero);

            return resultado;
        }

        public static bool Validar(Tramo op)
        {
            bool resultado = false;

            if (op != null && op.Carretera != null)
            {
                bool carreteraExiste = TListaCarretera.listaCarreteras.Any(
                    x => x.Codigo == op.Carretera.Codigo);

                if (carreteraExiste &&
                    op.Numero > 0 &&
                    op.KmInicial >= 0 &&
                    op.KmFinal > op.KmInicial &&
                    !double.IsNaN(op.KmInicial) &&
                    !double.IsNaN(op.KmFinal) &&
                    !double.IsInfinity(op.KmInicial) &&
                    !double.IsInfinity(op.KmFinal) &&
                    !double.IsInfinity(op.KmFinal - op.KmInicial))
                {
                    resultado = true;
                }
            }

            return resultado;
        }

        public static List<Tramo> GetLista()
        {
            return listaTramos.ToList();
        }
    }
}