using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public partial class Automovil
    {
       

        public void Conducir(int distancia)
        {
            double combustibleConsumido = distancia / RendimientoCombustible;
            if (NivelDeCombustible >= combustibleConsumido)
            {
                NivelDeCombustible -= combustibleConsumido;
                Console.WriteLine($"Se recorrio la distancia de {distancia} km sin reabastecer");
            }else
            {

                Console.WriteLine($"No hay suficiente combustible para recorrer la distancia de {distancia} km. " +
                    $"Se necesitan {combustibleConsumido - NivelDeCombustible:F2} galones adicionales");
            }
        }
        public void RestablecerCombustible(double cantidad)
        {
            double nuevoNivel = NivelDeCombustible + cantidad;
            if (nuevoNivel > capacidadDeTanqueEnGalones)
            {

                Console.WriteLine($"Se reabastecieron {capacidadDeTanqueEnGalones - NivelDeCombustible:F2} galones, llenando el tanque");
                NivelDeCombustible = capacidadDeTanqueEnGalones ;

            }else
            {
                Console.WriteLine($"Se restablecieron {cantidad:F2} galones");
                NivelDeCombustible = nuevoNivel ;
            }
        }

        public bool PuedeConducir(int distancia)
        {
            // para verificar si hay suficiente combustible
            double combustibleNecesario = distancia / RendimientoCombustible;

            return NivelDeCombustible >= combustibleNecesario;


        }
    }



}
