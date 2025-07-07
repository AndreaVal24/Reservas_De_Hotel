using System;
using Microsoft.Data.SqlClient;
using CapaDatos;
using Microsoft.Identity.Client;

namespace CapaNegocio
{
    public class Reserva
    {

        public Reserva() { }
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Habitacion { get; set; }
        public int Numero_Habitacion { get; set; }
        public DateTime Fecha { get; set; }
        public int DiasEstadia { get; set; }
        public decimal Precio { get; set; }
        public string Correo { get; set; }
        public bool CorreoEnviado { get; set; } //bool es para saber si se envio el correo o no, ya que en la base de datos
                                                //use un bit para eso, y en C# se usa bool para representar valores booleanos
                                                //bit es un tipo de dato que representa un valor booleano (solo puede ser 0 o 1).


    }
}

