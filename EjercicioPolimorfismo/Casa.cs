using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Casa : Inmueble
    {
        public Casa(string tipo,double precio, string lugar,Double Area   ) {
        this.tipoinmueble = tipo;
            this.precio = precio;
            this.ubicacion = lugar;
            this.areaterreno = Area;
        }
    }
}
