using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        protected int VelocidadMaxima { get; set; }
        protected int CapacidadTanque { get; set; }
        protected int ConsumoCombustible { get; set; }
        

        public virtual void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad -= 10;
                if (velocidad == 0)
                {
                    estadoVehiculo = 1;
                    Console.WriteLine("El vehículo se ha detenido.");
                }
                else
                {
                    Console.WriteLine($"El vehículo ha frenado a {velocidad} km/h.");
                }
            }
            else
            {
                Console.WriteLine("El vehículo ya está detenido.");
            }
        }

        public virtual void Encender()
        {
            if (piloto == null)
            {
                Console.WriteLine("No se puede encender sin un piloto asignado.");
                return;
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                Console.WriteLine("Vehículo encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public virtual void Apagar()
        {
            if (estadoVehiculo == 0)
            {
                Console.WriteLine("El vehículo ya está apagado.");
            }
            else if (velocidad > 0)
            {
                Console.WriteLine("No se puede apagar el vehículo mientras está en movimiento.");
            }
            else
            {
                estadoVehiculo = 0;
                Console.WriteLine("Vehículo apagado.");
            }
        }

        public virtual void CargarCombustible(double cantidad)
        {
            Console.WriteLine($"El vehículo cargo {cantidad} de combustible.");
        }


        private int velocidad = 0;

        //tipo de licencia
        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };

        private chofer piloto = null;
        protected int estadoVehiculo = 0; // 0= apagado, 1= encendido, 2= en movimiento;

        // agregar el m
        public string AsignarPiloto(chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado a este carro";
            }
            if (piloto != null)
            {
                return "Este vehiculo ya tiene asignado un piloto";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }

        public string encender()
        {
            if (piloto == null)
            {
                return "Nose puede encender sin un piloto asignado.";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Vehiculo arrancado.";
            }
            return "ya esta encendido.";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.VelocidadMaxima = 180;
            this.CapacidadTanque = 30; 
            this.ConsumoCombustible = 5;
        }

        public virtual void acelerar(int cuanto)
        {

            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine($"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.");
                velocidad = VelocidadMaxima;  
            }
            else
            {
                velocidad += cuanto;
                Console.WriteLine($"Vas a {velocidad} km/h.");
            }

            if (velocidad > 0)
            {
                estadoVehiculo = 2;  
            }
        }

        // Método para mostrar la información del vehículo
        public virtual void InformacionVehiculo()
        {
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Año: {this.Year}");
            Console.WriteLine($"Velocidad Máxima: {this.VelocidadMaxima} km/h");
            Console.WriteLine("Capacidad del Tanque: {0} galones", this.CapacidadTanque);
            Console.WriteLine("Consumo de Combustible: {0} galones/km", this.ConsumoCombustible);
            Console.WriteLine("Velocidad Actual: {0} km/h", this.velocidad);
            
            string estado = estadoVehiculo switch
            {
                0 => "Apagado",
                1 => "Encendido",
                2 => "En Movimiento",
                _ => "Estado desconocido"
            };
            Console.WriteLine("Estado del Vehículo: {0}", estado);

            
            if (piloto != null)
            {
                Console.WriteLine("Piloto Asignado: {0}", piloto.Nombre);
            }
            else
            {
                Console.WriteLine("No hay piloto asignado.");
            }
        }
    }
    
}
