using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Terreno:Inmueble

    {
        public Terreno(string TipoTerreno,double Valor,string Lugar,double tamano) {
        this.tipoinmueble = TipoTerreno;
            this.precio = Valor;
            this.ubicacion = Lugar;
            this.areaterreno = tamano;
        }    

    }
}
