using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Departamento : Inmueble
    {
        public Departamento(string tipodepa,double price,string lugar,double tamano) {
        this.tipoinmueble = tipodepa;
            this.precio = price;
            this.ubicacion = lugar;
            this.areaterreno = tamano;
        }   
    }
}
