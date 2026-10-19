using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarreteras.Entidades
{
    public class Tramo
    {
        private Carretera carretera;
        private int numero;
        private double kmInicial;
        private double kmFinal;

        public Tramo()
        {
        }

        public Tramo(Carretera carretera, int numero, double kmInicial, double kmFinal)
        {
            this.carretera = carretera;
            this.numero = numero;
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
        }

        public Carretera Carretera
        {
            get { return carretera; }
            set { carretera = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double KmInicial
        {
            get { return kmInicial; }
            set { kmInicial = value; }
        }

        public double KmFinal
        {
            get { return kmFinal; }
            set { kmFinal = value; }
        }

        public double Longitud
        {
            get
            {
                double resultado = kmFinal - kmInicial;
                return resultado;
            }
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

        public override string ToString()
        {
            return "Tramo " + numero;
        }
    }
}