using p1bpoo.MisClases;

internal class PIckUps : Vehiculo
{
    public PIckUps(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        tiposLicenciaAceptados = new List<string> { "B" };
        this.VelocidadMaxima = 180;
        this.CapacidadTanque = 50;
        this.ConsumoCombustible = 10;

    }
}

