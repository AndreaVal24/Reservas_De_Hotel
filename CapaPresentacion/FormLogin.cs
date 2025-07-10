using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Importaciones necesarias para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void txtuser_Enter(object sender, EventArgs e) //evento para cuando el usuario entra al campo de texto
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            // Evento para cuando el usuario sale del campo de texto
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            // Evento para cuando el usuario entra al campo de texto
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true; // Muestra los caracteres como puntos
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            // Evento para cuando el usuario sale del campo de texto
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false; // Muestra el texto como está
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }


        // Evento para permitir mover la ventana al hacer clic y arrastrar
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Evento para permitir mover la ventana al hacer clic y arrastrar en el panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        // Evento para el botón de inicio de sesión
        private void btnLogin_Click(object sender, EventArgs e)
        {
       

            try
            {
                string usuario = txtuser.Text.Trim(); // Elimina espacios en blanco al inicio y al final
                string contrasena = txtpass.Text;

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena)) // Verifica si los campos están vacíos
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                    return;
                }

                
                string caracteresInvalidos = "'\";-- "; // Define los caracteres no permitidos en el usuario y la contraseña

                foreach (char c in caracteresInvalidos) // Recorre cada carácter no permitido
                {
                    if (usuario.Contains(c) || contrasena.Contains(c))  // Verifica si el usuario o la contraseña contienen caracteres no permitidos
                    {
                        MessageBox.Show("El usuario o la contraseña contiene caracteres no permitidos (como comillas, punto y coma o espacios).");
                        return;
                    }
                }


                CNUsuario acceso = new CNUsuario(); // Instancia de la clase CNUsuario que maneja la lógica de negocio para el login
                string rol = acceso.VerificarLogin(usuario, contrasena); // Llama al método para verificar el login

                // Si el rol es diferente de null, significa que el usuario y la contraseña son correctos
                if (rol != null)
                {
                    MessageBox.Show("¡Bienvenido, " + rol + "!"); // Mensaje de bienvenida al usuario
                    

                    Form2 menu = new Form2();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier error no controlado (por ejemplo, caída de conexión)
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //utilice un try-catch para manejar errores no controlados, como problemas de conexión a la base de datos


        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtuser.MaxLength = 20; // Establece el máximo de caracteres para el campo de usuario
            txtpass.MaxLength = 20; // Establece el máximo de caracteres para el campo de contraseña
        }
    }
}
