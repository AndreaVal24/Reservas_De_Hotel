using CapaDatos;
using CapaNegocio;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class FormGraficos : Form
    {
        public FormGraficos()
        {
            InitializeComponent();
            ObtenerEmpleados();  // Carga los empleados al iniciar el formulario
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.AutoScaleMode = AutoScaleMode.None; // Evita redibujos innecesarios

            cbCargo.Items.Clear();

            cbCargo.Items.Add("Gerente");
            cbCargo.Items.Add("Recepcionista");
            cbCargo.Items.Add("Chef");
            cbCargo.Items.Add("Personal de Limpieza");
            cbCargo.Items.Add("Personal de Mantenimiento");
            cbCargo.Items.Add("Personal de Seguridad");

            cbCargo.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            dtpFechasIngresoEm.Value = DateTime.Today; // Establece la fecha de ingreso al día actual

            txtNombreEm.MaxLength = 30; // Limita el nombre 

            //a la cedula no le agregue Masketextbox porque no quiero solo el formato de cedula dominicana
            //quiero que el usuario pueda ingresar cualquier cedula, la mas larga es de 11 caracteres

            txtCedula.MaxLength = 11; // Limita la cédula 
            txtBuscarporcedula.MaxLength = 13; // Limita la búsqueda de cédula

            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList; // Evita que el usuario escriba en el ComboBox

        }


        private void LimpiarCampos() //metodo para limpiar los campos del formulario
        {
            txtNombreEm.Text = "";
            txtCedula.Text = "";
            cbCargo.SelectedIndex = 0;
            txtSueldo.Text = "";
            dtpFechasIngresoEm.Value = DateTime.Today;

        }



        //boton calcular sueldo
        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            //calcular sueldo
            string cargo = cbCargo.SelectedItem.ToString();
            decimal sueldoBase = 0;

            if (cargo == "Gerente")
            {
                Empleado gerente = new Gerente();  // Crea una instancia de Gerente sin parámetros (constructor por defecto)
                sueldoBase = gerente.sueldoGC();
            }
            else if (cargo == "Chef")
            {
                Empleado chef = new Chef();
                sueldoBase = chef.sueldoGC();
            }
            else if (cargo == "Recepcionista")
            {
                Empleado recepcionista = new Recepcionista();
                sueldoBase = recepcionista.sueldoR();
            }
            else if (cargo == "Personal de Limpieza")
            {
                Empleado limpieza = new Limpieza();
                sueldoBase = limpieza.sueldoGC();
            }
            else if (cargo == "Personal de Mantenimiento")
            {
                Empleado mantenimiento = new Mantenimiento();
                sueldoBase = mantenimiento.sueldoGC();
            }
            else if (cargo == "Personal de Seguridad")
            {
                Empleado seguridad = new Seguridad();
                sueldoBase = seguridad.sueldoGC();
            }

            txtSueldo.Text = sueldoBase.ToString("F2");  // Esto convierte el sueldo a string para mostrarlo en el TextBox 
                                                         //y el F2 lo formatea a dos decimales
        }



        //boton agregar empleado
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtNombreEm.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("Debe calcular el sueldo antes de guardar.");
                return;
            }

            // Creo el empleado segun el cargo seleccionado
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombreEm.Text;
            string cargo = cbCargo.SelectedItem.ToString();
            DateTime fechaIngreso = dtpFechasIngresoEm.Value;
            Empleado empleado;

            if (cargo == "Gerente")
                empleado = new Gerente(nombre, cedula, fechaIngreso);
            else if (cargo == "Chef")
                empleado = new Chef(nombre, cedula, fechaIngreso);
            else if (cargo == "Recepcionista")
                empleado = new Recepcionista(nombre, cedula, fechaIngreso);
            else if (cargo == "Personal de Limpieza")
                empleado = new Limpieza(nombre, cedula, fechaIngreso);
            else if (cargo == "Personal de Mantenimiento")
                empleado = new Mantenimiento(nombre, cedula, fechaIngreso);
            else // Seguridad
                empleado = new Seguridad(nombre, cedula, fechaIngreso);

            if (cargo == "Recepcionista")
            {
                empleado.Sueldo = empleado.sueldoR();
            }
            else
            {
                empleado.Sueldo = empleado.sueldoGC();
            }

            EmpleadoNegocio negocio = new EmpleadoNegocio();

            if (idEmpleadoEditado != -1)  // en caso de estar editando
            {
                empleado.ID = idEmpleadoEditado;
                negocio.EditarEmpleado(empleado);
                MessageBox.Show("Empleado actualizado correctamente.");

                idEmpleadoEditado = -1;
                btnAgregarEmpleado.Text = "Agregar Empleado";
                btnAgregarEmpleado.BackColor = SystemColors.Control; // Cambia el color de fondo del botón a su valor por defecto
                btnAgregarEmpleado.ForeColor = SystemColors.ControlText;
            }
            else  // agregando un nuevo empleado
            {
                int result = negocio.InsertarEmpleado(empleado);
                if (result > 0)
                {
                    MessageBox.Show("Empleado registrado.");
                }
                else
                {
                    MessageBox.Show("Error al guardar.");
                }
            }

            ObtenerEmpleados();
            LimpiarCampos();
        }



        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //DGV
        private void ObtenerEmpleados()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection conn = new SqlConnection(conexion.CadenaConexion))
            {
                conn.Open();
                string query = "SELECT * FROM Empleados";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                }
            }
        }



        //boton para eliminar empleado
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0) // verifica si hay una fila seleccionada
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar el empleado del sistema?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes) //si el usuario confirma la eliminación
                                                      //si no la confirma, no hace nada 
                {
                    try // Intenta eliminar el empleado seleccionado
                    {
                        int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);
                        EmpleadoNegocio negocio = new EmpleadoNegocio();
                        negocio.EliminarEmpleado(idEmpleado);
                        ObtenerEmpleados(); // Recarga el DataGridView

                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) // Captura cualquier excepción que ocurra durante la eliminación
                    {
                        MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Si no hay filas seleccionadas, muestra un mensaje de advertencia
            }
        }





        private int idEmpleadoEditado = -1; // Variable para almacenar el ID del empleado que se está editando

        //boton para EDITAR
        private void btnEditarEm_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para editar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "¿Estás seguro de que deseas editar los datos del empleado seleccionado?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return; // Si el usuario cancela, no hace nada, el return hace que se salga del metodo
                //si el usuario presiona No, no se ejecuta el resto del código, si presiona Si, se continua con el resto del código
            }

            DataGridViewRow row = dgvEmpleados.SelectedRows[0];
            idEmpleadoEditado = Convert.ToInt32(row.Cells["ID"].Value); // Guardar ID para saber que estamos editando

            // Llenar los campos con los datos seleccionados
            txtNombreEm.Text = row.Cells["Nombre"].Value.ToString();
            txtCedula.Text = row.Cells["Cedula"].Value.ToString();
            cbCargo.SelectedItem = row.Cells["Cargo"].Value.ToString();
            dtpFechasIngresoEm.Value = Convert.ToDateTime(row.Cells["Fecha_Ingreso"].Value);

            btnAgregarEmpleado.Text = "Guardar Cambios"; // Cambia el texto del botón
            btnAgregarEmpleado.BackColor = System.Drawing.Color.DarkOliveGreen;
            btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
        }



        private void btnVolverEmpleado_Click(object sender, EventArgs e)  //boton para volver al menu principal
        {
           
        }


        private void txtNombreEm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)) // Verifica si la tecla presionada no es un control (como retroceso)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) // Verifica si no es una letra o espacio
                {
                    e.Handled = true; // Si no es válido, ignora la entrada
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e) // Validar que solo se ingresen números en el campo de cédula
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e) // Validar que se seleccione un cargo
        {
            if (cbCargo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cargo.");
                return;
            }
            txtSueldo.Clear();

        }



        //boton para buscar empleado por cedula
        private void btnBuscarporcedula_Click(object sender, EventArgs e)
        {
            //cedula es el campo de texto donde se ingresa la cédula del empleado a buscar
            string cedula = txtBuscarporcedula.Text.Trim();

            // validar que la cédula no esté vacía
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Ingrese una cédula para buscar.");
                return;
            }

            EmpleadoNegocio negocio = new EmpleadoNegocio(); // Instancia de la clase EmpleadoNegocio para acceder a
                                                             // los metodos de negocio

            DataTable resultado = negocio.BuscarEmpleadoPorCedula(cedula); // Llama al método BuscarEmpleadoPorCedula
                                                                           // para obtener los datos del empleado
                                                                           //es una variable tipo DataTable que
                                                                           //almacena el resultado de la búsqueda

            // Verifica si se encontraron resultados
            if (resultado.Rows.Count > 0)
            {
                dgvEmpleados.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No existe un empleado con esa cédula en el sistema.");
                dgvEmpleados.DataSource = null;
            }

            txtBuscarporcedula.Clear();
        }



        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //utillizamos el metodo ObtenerEmpleados para mostrar todos los empleados
            ObtenerEmpleados();
        }



        private void txtBuscarporcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           //solo acepte numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Si no es un número, ignora la entrada
            }
        }

        private void btnExportarEmpleados_Click(object sender, EventArgs e) // Botón para exportar los datos del DataGridView a un archivo Excel
        {

            if (dgvEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog
            {
                Filter = "Archivos Excel (*.xlsx)|*.xlsx",
                FileName = $"Empleados_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                DataTable tabla = (DataTable)dgvEmpleados.DataSource;
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                negocio.ExportarEmpleadosAExcel(tabla, guardar.FileName);
                MessageBox.Show("Exportación completada.");
            }

        }





    }
}
