using p1bpoo.MisClases;

internal class Moto : Vehiculo
{
    public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        tiposLicenciaAceptados = new List<string> { "M" };
        this.VelocidadMaxima = 120;
        this.CapacidadTanque = 15;
        this.ConsumoCombustible = 5;
    }
    public void HacerCaballito()
    {
        if (estadoVehiculo == 2)
        {
            Console.WriteLine("¡La moto está haciendo un caballito!");
        }
        else
        {
            Console.WriteLine("No se puede hacer caballito, la moto debe estar en movimiento.");
        }
    }

    
    public override void acelerar(int cuanto)
    {
        base.acelerar(cuanto); 
    }

    public override void InformacionVehiculo()
    {
        base.InformacionVehiculo();
        Console.WriteLine("Información específica de la moto:");
        Console.WriteLine("Capacidad del Tanque: {0} galones", this.CapacidadTanque);
        Console.WriteLine("Consumo de Combustible: {0} galones/km", this.ConsumoCombustible);
        Console.WriteLine("Velocidad Máxima: {0} km/h", this.VelocidadMaxima);
    }
}




