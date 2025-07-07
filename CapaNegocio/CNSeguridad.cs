using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Seguridad : Empleado  //clase que hereda de empleado
    {
        public Seguridad() : base("", "", "Personal de Seguridad", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo
        public Seguridad(string nombre, string cedula, DateTime fechaIngreso)
            : base(nombre, cedula, "Personal de Seguridad", fechaIngreso)
        {
        }
        public override decimal sueldoGC()   //metodo abstracto
        {
            return 42000; //sueldo personal de seguridad
        }
    }
    
    
}
