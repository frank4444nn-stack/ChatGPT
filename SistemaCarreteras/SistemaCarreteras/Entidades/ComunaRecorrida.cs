using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class ComunaRecorrida
    {
        private Tramo tramo;
        private Comuna comuna;
        private int orden;
        private double kmEntrada;
        private double kmSalida;

        public ComunaRecorrida()
        {
        }

        public ComunaRecorrida(Tramo tramo, Comuna comuna, int orden,
            double kmEntrada, double kmSalida)
        {
            this.tramo = tramo;
            this.comuna = comuna;
            this.orden = orden;
            this.kmEntrada = kmEntrada;
            this.kmSalida = kmSalida;
        }

        public Tramo Tramo
        {
            get { return tramo; }
            set { tramo = value; }
        }

        public Comuna Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }

        public int Orden
        {
            get { return orden; }
            set { orden = value; }
        }

        public double KmEntrada
        {
            get { return kmEntrada; }
            set { kmEntrada = value; }
        }

        public double KmSalida
        {
            get { return kmSalida; }
            set { kmSalida = value; }
        }

        public string NombreCarretera
        {
            get
            {
                string resultado = "";

                if (tramo != null && tramo.Carretera != null)
                {
                    resultado = tramo.Carretera.Nombre;
                }

                return resultado;
            }
        }

        public int NumeroTramo
        {
            get
            {
                int resultado = 0;

                if (tramo != null)
                {
                    resultado = tramo.Numero;
                }

                return resultado;
            }
        }

        public string NombreComuna
        {
            get
            {
                string resultado = "";

                if (comuna != null)
                {
                    resultado = comuna.Nombre;
                }

                return resultado;
            }
        }
    }
}