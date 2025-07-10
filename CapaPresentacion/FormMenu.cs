using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        //campos
        private IconButton currentBtn; //para el boton actual
        private Panel leftBorderBtn; //para el borde del boton actual
        private Form formularioActivo = null; //para el formulario activo

        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 120); //tamaño del borde
            panelContenido.Controls.Add(leftBorderBtn); //agrega el borde al panel de contenido


        }

        //no pude cambiar los nombres de los formularios, me daba error
        //formEmpleados es el formulario de reservas y FormGraficos es el de empleados
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //boton confirmaciones
        private void iconbtnConfirmaciones_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.color4); //activa el boton reservas con el color especificado
            AbrirFormularioHijo(new FormCorreoReservas()); //este es el formulario de confirmaciones
            lblHome.Text = "Confirmaciones"; // Cambia el texto arriba
        }

        // boton reservas
        private void iconbtnReservas_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.color1); //activa el boton reservas con el color especificado
            AbrirFormularioHijo(new FormEmpleados()); //este es el formulario de reservas
            lblHome.Text = "Reservas"; // Cambia el texto arriba

        }

        //boton empleados
        private void iconbtnEmpleado_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.color2); //activa el boton reservas con el color especificado       
            AbrirFormularioHijo(new FormGraficos()); //este es el formulario de empleados
            lblHome.Text = "Empleados";

        }




        //boton salir
        private void iconbtnSalir_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.color3); //activa el boton reservas con el color especificado

            //salir del programa
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); //cierra la aplicacion
            }
        }


        //metodo para activar el boton actual
        private void BotonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BotonDesactivado(); //desactiva el boton actual si hay uno activo

                currentBtn = (IconButton)senderBtn; //asigna el boton actual
                currentBtn.BackColor = Color.FromArgb(255, 255, 255); //cambia el color de fondo del boton actual
                currentBtn.ForeColor = color; //cambia el color del texto del boton actual
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; //cambia la alineacion del texto del boton actual
                currentBtn.IconColor = color; //cambia el color del icono del boton actual
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; //cambia la relacion del texto con la imagen del boton actual
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //cambia la alineacion de la imagen del boton actual
                leftBorderBtn.BackColor = color; //cambia el color del borde del boton actual
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y); //cambia la posicion del borde del boton actual   
                leftBorderBtn.Visible = true; //hace visible el borde del boton actual
                leftBorderBtn.BringToFront(); //trae el borde del boton actual al frente

                //icono actual de la barra superior
                iconBarra.IconChar = currentBtn.IconChar; //cambia el icono de la barra superior al icono del boton actual
                iconBarra.IconColor = currentBtn.IconColor; //cambia el color del icono de la barra superior al color del boton actual

            }
        }

        //metodo para desactivar el boton actual
        private void BotonDesactivado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(184, 134, 11); //cambia el color de fondo del boton actual
                currentBtn.ForeColor = Color.Gainsboro; //cambia el color del texto del boton actual
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; //cambia la alineacion del texto del boton actual
                currentBtn.IconColor = Color.Gainsboro; //cambia el color del icono del boton actual
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; //cambia la relacion del texto con la imagen del boton actual
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; //cambia la alineacion de la imagen del boton actual
            }
        }

        private void pbinicio_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void Reset() 
        {
            BotonDesactivado();
            leftBorderBtn.Visible = false;
            iconBarra.IconChar = IconChar.Home;
            iconBarra.IconColor = Color.White;
            lblHome.Text = "Inicio";

            // Cierra el formulario activo si hay uno abierto
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }

            // Vuelve a mostrar el logo
            iconlogocentro.Visible = true;
        }


        private void panelBarrasuperior_Paint(object sender, PaintEventArgs e)
        {


        }

        //estructura para los colores d elos botones
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(160, 82, 45);
            public static Color color2 = Color.FromArgb(128, 128, 0);
            public static Color color3 = Color.FromArgb(0, 0, 128);
            public static Color color4 = Color.FromArgb(139, 0, 139);


        }

        private void AbrirFormularioHijo(Form formHijo)
        {
            // Cierra el formulario anterior si hay uno abierto
            if (formularioActivo != null)
                formularioActivo.Close();

            // Oculta el logo del centro
            iconlogocentro.Visible = false;

            formularioActivo = formHijo; // Asigna el formulario hijo a la variable de formulario activo
            formHijo.TopLevel = false;  // Indica que el formulario hijo no es de nivel superior, es decir que no es una ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None;  // Elimina el borde del formulario hijo
            formHijo.Dock = DockStyle.Fill;  // Hace que el formulario hijo ocupe todo el espacio disponible en el panel

            panelFORMULARIOS.SuspendLayout(); // DETIENE el redibujo

            panelFORMULARIOS.Controls.Add(formHijo);  // Agrega el formulario hijo al panel de formularios
            panelFORMULARIOS.Tag = formHijo;   // Asigna el formulario hijo al tag del panel de formularios

            formHijo.BringToFront();  // Trae el formulario hijo al frente para que sea visible
            formHijo.Show();   // Muestra el formulario hijo

            panelFORMULARIOS.ResumeLayout();  // Reanuda el redibujo del panel de formularios, esto es necesario para que los cambios se
                                              // reflejen correctamente en la interfaz de usuario
        }

        private void pblogoenmedio_Click(object sender, EventArgs e)
        {

        }

       
    }
}
