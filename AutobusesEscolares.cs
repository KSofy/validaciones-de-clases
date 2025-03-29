

using p1bpoo.MisClases;
internal class AutobusesEscolares : Vehiculo
{
    public AutobusesEscolares(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
    {
        tiposLicenciaAceptados = new List<string> { "A" };
        this.VelocidadMaxima = 90;
        this.CapacidadTanque = 70;
        this.ConsumoCombustible = 10;
    }
}
