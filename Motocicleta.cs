using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int _cilindraje; // Encapsulación

        public string TipoMotocicleta { get; set; }
        public bool TieneParabrisas { get; set; }

        public Motocicleta(int anio, string elColor, string elModelo, int cilindraje)
            : base(anio, elColor, elModelo)
        {
            _cilindraje = cilindraje;
        }

        public int Cilindraje
        {
            get { return _cilindraje; }
            set { _cilindraje = value; }
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto * 2); // La motocicleta acelera más rápido
        }

    }
}

