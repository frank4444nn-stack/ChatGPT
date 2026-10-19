using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class ExtremoCarretera
    {
        private Carretera carretera;
        private string tipoExtremo;
        private Tramo tramo;
        private Comuna comuna;
        private double kilometro;
        private string tipoFinalizacion;

        private Carretera carreteraDestino;
        private Tramo tramoDestino;
        private Comuna comunaDestino;
        private double kmDestino;
        private string observacion;

        public ExtremoCarretera()
        {
        }

        public ExtremoCarretera(
            Carretera carretera,
            string tipoExtremo,
            Tramo tramo,
            Comuna comuna,
            double kilometro,
            string tipoFinalizacion,
            Carretera carreteraDestino,
            Tramo tramoDestino,
            Comuna comunaDestino,
            double kmDestino,
            string observacion)
        {
            this.carretera = carretera;
            this.tipoExtremo = tipoExtremo;
            this.tramo = tramo;
            this.comuna = comuna;
            this.kilometro = kilometro;
            this.tipoFinalizacion = tipoFinalizacion;
            this.carreteraDestino = carreteraDestino;
            this.tramoDestino = tramoDestino;
            this.comunaDestino = comunaDestino;
            this.kmDestino = kmDestino;
            this.observacion = observacion;
        }

        public Carretera Carretera
        {
            get { return carretera; }
            set { carretera = value; }
        }

        public string TipoExtremo
        {
            get { return tipoExtremo; }
            set { tipoExtremo = value; }
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

        public double Kilometro
        {
            get { return kilometro; }
            set { kilometro = value; }
        }

        public string TipoFinalizacion
        {
            get { return tipoFinalizacion; }
            set { tipoFinalizacion = value; }
        }

        public Carretera CarreteraDestino
        {
            get { return carreteraDestino; }
            set { carreteraDestino = value; }
        }

        public Tramo TramoDestino
        {
            get { return tramoDestino; }
            set { tramoDestino = value; }
        }

        public Comuna ComunaDestino
        {
            get { return comunaDestino; }
            set { comunaDestino = value; }
        }

        public double KmDestino
        {
            get { return kmDestino; }
            set { kmDestino = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public string NombreCarretera
        {
            get
            {
                string resultado = "";

                if (carretera != null)
                {
                    resultado = carretera.Nombre;
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

        public string NombreCarreteraDestino
        {
            get
            {
                string resultado = "";

                if (carreteraDestino != null)
                {
                    resultado = carreteraDestino.Nombre;
                }

                return resultado;
            }
        }

        public string NombreTramo
        {
            get
            {
                string resultado = "";

                if (tramo != null)
                {
                    resultado = tramo.ToString();
                }

                return resultado;
            }
        }

        public override string ToString()
        {
            return tipoExtremo + " - " + NombreCarretera;
        }
    }
}