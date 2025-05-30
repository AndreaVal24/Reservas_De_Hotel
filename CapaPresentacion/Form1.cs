using System;
using CapaNegocio;
using CapaDatos;
using System.Drawing.Text;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            int ID;
            if (!int.TryParse(txtID.Text, out ID))
            {
                MessageBox.Show("No se encuentra la reserva");
                return;

            }

            ReservaNegocio negocio = new ReservaNegocio();

            Reserva reserva = negocio.CalcularCostoFinal(ID);
            if (reserva != null)
            {

                txtCLIENTE.Text = reserva.Cliente;
                txtHABITACION.Text = reserva.Habitacion;
                txtNUMERO.Text = reserva.Numero_Habitacion.ToString(); ;  //para que pueda leerlo el txt, ya que leer solo string
                txtFECHA.Text = reserva.Fecha.ToShortDateString(); ;



            }
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {

        }
    }
}
