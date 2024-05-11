namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Automovil Vehiculo1 = new Automovil("Honda","CDA432","Civic","Negro",60,15);

            Vehiculo1.MostrarInformacion();
            Vehiculo1.Conducir(100);
            Vehiculo1.RestablecerCombustible(10);
            Vehiculo1.Conducir(50);
        }
    }
}
