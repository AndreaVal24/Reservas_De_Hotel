using CapaDatos;

namespace CapaNegocio
{
    public class ReservaNegocio
    {
        //clase que accede a la base de datos
        private ReservaDatos datos = new ReservaDatos();

        public Reserva CalcularCostoFinal(int idReserva)
        {
            return datos.CalcularCostoFinal(idReserva);
        }
    }
}
