public class chofer : Ipiloto
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string TipoLicencia { get; set; }

    public chofer(string name, int edadPiloto, string tipo)
    {
        Nombre = name;
        Edad = edadPiloto;
        TipoLicencia = tipo;

    
            if (!EsLicenciaValida(tipo))
            {
                throw new ArgumentException($"La edad no es válida para la licencia tipo {tipo}. Revisa los requisitos de edad.");
            }

            TipoLicencia = tipo;
        }

        private bool EsLicenciaValida(string tipo)
        {
            
            tipo = tipo.ToUpper();

           
            if (tipo == "A" || tipo == "B")
            {
              
                return Edad >= 18;
            }
            else if (tipo == "C" || tipo == "D" || tipo == "E")
            {
                
                return Edad >= 21;
            }
            else
            {
               
                return false;
            }
        }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}", this.Nombre);
        Console.WriteLine("Edad: {0}", this.Edad);
        Console.WriteLine("Tipo de Licencia: {0}", this.TipoLicencia);
    }

}
   