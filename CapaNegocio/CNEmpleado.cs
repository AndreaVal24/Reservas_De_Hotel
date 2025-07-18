﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Empleado  //clase abstracta
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime Fecha_Ingreso { get; set; }


        //constructor que usare en el form
        public Empleado(string nombre, string cedula, string cargo, DateTime fechaIngreso)
        {
            Nombre = nombre;
            Cedula = cedula;
            Cargo = cargo;
            Fecha_Ingreso = fechaIngreso;
        }

        public abstract decimal sueldoGC();    //metodo abstracto, sueldo gerente, chef o limpieza

        public virtual decimal sueldoR()      //metodo virtual, sueldo recepcionista
        {
            return 0; //debe devolver algo, aunque sea 0, porque es un metodo virtual, en la hija lo sobreescribiremos
        }

    }
 
}
