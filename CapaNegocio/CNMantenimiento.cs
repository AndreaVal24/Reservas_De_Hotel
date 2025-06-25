using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Mantenimiento : Empleado  //clase que hereda de empleado
    {
        public Mantenimiento() : base("", 0, "Personal de Mantenimiento", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo
        public Mantenimiento(string nombre, int cedula, DateTime fechaIngreso)
            : base(nombre, cedula, "Personal de Mantenimiento", fechaIngreso)
        {
        }
        public override decimal sueldoGC()   //metodo abstracto
        {
            return 38000; //sueldo personal de mantenimiento
        }
    }
    
}
