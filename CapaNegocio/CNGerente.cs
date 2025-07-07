using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Gerente : Empleado
    {
        public Gerente() : base("", "", "Gerente", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo

        public Gerente(string nombre, string cedula, DateTime fechaIngreso)   //constructor que heredamos de la base
            : base(nombre, cedula, "Gerente", fechaIngreso)
        {
        }

        //implementamos metodo abstracto
        public override decimal sueldoGC()
        {
            return 50000; //sueldo gerente
        }
    }
}
