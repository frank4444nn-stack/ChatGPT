using SistemaCarreteras.Entidades;
using System;

namespace SistemaCarreteras.Controladores
{
    // Datos de práctica; se cargan una sola vez por ejecución, nunca al volver a una pantalla.
    public class TListaDatos
    {
        private static bool cargado;
        public static void CargarDatos()
        {
            if (cargado) return;
            cargado = true;
            if (TListaCategoria.GetLista().Count != 0 || TListaCarretera.GetLista().Count != 0 ||
                TListaComuna.GetLista().Count != 0 || TListaTramo.GetLista().Count != 0 ||
                TListaComunaRecorrida.GetLista().Count != 0 || TListaExtremoCarretera.GetLista().Count != 0) return;
            TListaCategoria.Agregar(new Categoria(1, "Local"));
            TListaCategoria.Agregar(new Categoria(2, "Comercial"));
            TListaCategoria.Agregar(new Categoria(3, "Regional"));
            TListaCategoria.Agregar(new Categoria(4, "Nacional"));
            TListaCategoria.Agregar(new Categoria(5, "Autovía"));
            TListaCarretera.Agregar(new Carretera(101, "Vía Machala - Pasaje", TListaCategoria.Buscar(3)));
            TListaCarretera.Agregar(new Carretera(102, "Vía Machala - Santa Rosa", TListaCategoria.Buscar(4)));
            TListaCarretera.Agregar(new Carretera(103, "Vía Puerto Bolívar", TListaCategoria.Buscar(1)));
            TListaCarretera.Agregar(new Carretera(104, "Vía Comercial Central", TListaCategoria.Buscar(2)));
            TListaCarretera.Agregar(new Carretera(105, "Autovía Principal", TListaCategoria.Buscar(5)));
            TListaComuna.Agregar(new Comuna(1, "Machala", "Machala", "El Oro"));
            TListaComuna.Agregar(new Comuna(2, "El Cambio", "Machala", "El Oro"));
            TListaComuna.Agregar(new Comuna(3, "Pasaje", "Pasaje", "El Oro"));
            TListaComuna.Agregar(new Comuna(4, "Santa Rosa", "Santa Rosa", "El Oro"));
            TListaComuna.Agregar(new Comuna(5, "Puerto Bolívar", "Machala", "El Oro"));
            TListaComuna.Agregar(new Comuna(6, "Comuna sin relaciones", "Arenillas", "El Oro"));
            foreach (Carretera carretera in TListaCarretera.GetLista())
            {
                TListaTramo.Agregar(new Tramo(carretera, 1, 0, 10));
                TListaTramo.Agregar(new Tramo(carretera, 2, 10, 20));
                Tramo primero = TListaTramo.Buscar(carretera.Codigo, 1);
                Tramo segundo = TListaTramo.Buscar(carretera.Codigo, 2);
                TListaComunaRecorrida.Agregar(new ComunaRecorrida(primero, TListaComuna.Buscar(1), 1, 0, 5));
                TListaComunaRecorrida.Agregar(new ComunaRecorrida(primero, TListaComuna.Buscar(2), 2, 5, 10));
                int codigoComuna = carretera.Codigo == 102 ? 4 : carretera.Codigo == 103 ? 5 : 3;
                TListaComunaRecorrida.Agregar(new ComunaRecorrida(segundo, TListaComuna.Buscar(codigoComuna), 1, 10, 20));
                TListaExtremoCarretera.Agregar(new ExtremoCarretera(carretera, "Inicio", primero,
                    TListaComuna.Buscar(1), 0, "Finalización física", null, null, null, 0, ""));
            }
            // Ejemplo ficticio de confluencia en El Cambio (no representa cartografía real).
            TListaExtremoCarretera.Agregar(new ExtremoCarretera(TListaCarretera.Buscar(101), "Final",
                TListaTramo.Buscar(101, 2), TListaComuna.Buscar(3), 20, "Confluencia con otra carretera",
                TListaCarretera.Buscar(102), TListaTramo.Buscar(102, 1), TListaComuna.Buscar(2), 7,
                "Ejemplo académico de unión vial"));
        }
    }
}
