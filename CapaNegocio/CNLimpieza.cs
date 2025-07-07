using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Limpieza : Empleado  //clase que hereda de empleado
    {
        public Limpieza() : base("", "", "Personal de Limpieza", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo

        public Limpieza(string nombre, string cedula, DateTime fechaIngreso)
        : base(nombre, cedula, "Personal de Limpieza", fechaIngreso)
        {
        }

        public override decimal sueldoGC()   //metodo abstracto
        {
            return 35000; 
        }
    }
}
