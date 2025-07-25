﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Recepcionista : Empleado
    {

        public Recepcionista() : base("", "", "Recepcionista", DateTime.Today) { } //constructor vacio para el metodo calcular sueldo


        public Recepcionista(string nombre, string cedula, DateTime fechaIngreso)  //llamamos al constructor 
                                                                                //de la clase base Empleado, para inicializar los atributos comunes
        : base(nombre, cedula, "Recepcionista", fechaIngreso)
        {
        }

        public override decimal sueldoR()  //metodo virtual
        {
            return 40000;  //asignamos un sueldo fijo para el recepcionista
        }

        //debo llamar tambien el metodo abstracto, porque se exije que se usen en todas las clases hijas, es obligatorio
        public override decimal sueldoGC()  //metodo abstracto
        {
            return 0; 
        }
    }
}
