using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    //no tiene que ser abstracta esta clase, pues no necesito mas metodos que hereden de esta clase para despues
    public class Chef : Empleado
    {
        public Chef() : base("", 0, "Chef", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo

        public Chef(string nombre, int cedula, DateTime fechaIngreso)
        : base(nombre, cedula, "Chef", fechaIngreso)
        {
        }

        public override decimal sueldoGC()   //metodo abstracto
        {
            return 45000; //sueldo chef
        }
    }
}
