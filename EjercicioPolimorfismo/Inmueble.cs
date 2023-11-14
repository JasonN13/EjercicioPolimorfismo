using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Inmueble
    {
        public string? tipoinmueble {  get; set; }
        public string? ubicacion {  get; set; }
        public double areaterreno { get; set; }
        public double precio { get; set; }

        public void Venta()
        {
            Console.WriteLine(tipoinmueble + "  Se vendio por el L: " + precio);
        }
         public void Ubicacion()
        {
            Console.WriteLine(" La propiedad se encuentra " + ubicacion + " Y el tamaño es " + areaterreno + " M2");
        }

    }
    
}
