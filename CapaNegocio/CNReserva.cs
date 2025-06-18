using System;
using Microsoft.Data.SqlClient;
using CapaDatos;

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
    }
}

