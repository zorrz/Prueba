using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public partial class Automovil
    {
        public string marca { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public double capacidadDeTanqueEnGalones { get; set; }
        public double NivelDeCombustible { get; set; }
        public double RendimientoCombustible { get; set; }

        public Automovil(string marca, string placa, string modelo, string color, double capacidadDeTanqueEnGalones, double rendimientoCombustible)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.color = color;
            this.capacidadDeTanqueEnGalones = capacidadDeTanqueEnGalones;
            NivelDeCombustible = 0;
            RendimientoCombustible = rendimientoCombustible;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Informacion del Automovil:");
            Console.WriteLine($"Marca = {marca}");
            Console.WriteLine($"Placa = {placa}");
            Console.WriteLine($"Modelo = {modelo}");
            Console.WriteLine($"Color = {color}");
            Console.WriteLine($"Capacidad del tanque = {capacidadDeTanqueEnGalones}");
            Console.WriteLine($"Nivel de combustible = {NivelDeCombustible}");
            Console.WriteLine($"Rendimiento del combustible = {RendimientoCombustible}");
            Console.WriteLine();
        }
    }
}
