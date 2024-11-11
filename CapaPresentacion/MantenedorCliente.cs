using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaLogica;
using System.Data;
using CapaAccesoDatos;


namespace CapaPresentacion
{
    public partial class MantenedorCliente : Form
    {
        private bool cambiosRealizados = false; // Indicador de cambios en dtgvClientes
        private SqlConnection conexion;
        public MantenedorCliente()
        {
            InitializeComponent();
            dtgvClientes.CellValueChanged += dtgvClientes_CellValueChanged; // Detectar cambios en celdas
            conexion = Conexion.Instancia.Conectar(); // Usa el patrón Singleton para la conexión
            CargarClientes(); // Cargar datos al iniciar el formulario
        }
        // Método para cargar la lista de clientes en el DataGridView
        private void CargarClientes()
        {
            try
            {
                List<entCliente> listaClientes = logCliente.Instancia.ListarCliente();
                dtgvClientes.DataSource = listaClientes;

                // Configuración de columnas
                dtgvClientes.Columns["idCliente"].HeaderText = "ID Cliente";
                dtgvClientes.Columns["razonSocial"].HeaderText = "Nombre del Cliente";
                dtgvClientes.Columns["dni"].HeaderText = "DNI";
                dtgvClientes.Columns["numero"].HeaderText = "Número";
                dtgvClientes.Columns["correo"].HeaderText = "Correo Electrónico";
                dtgvClientes.Columns["fecRegCliente"].HeaderText = "Fecha de Registro";
                dtgvClientes.Columns["estCliente"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Evento para detectar cambios en dtvinsumo
        private void dtgvClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            cambiosRealizados = true;
        }

        // Método auxiliar para abrir una única instancia de un formulario
        private void AbrirFormularioUnico(Type tipoFormulario)
        {
            // Recorre los formularios abiertos y verifica si ya existe el tipo de formulario deseado
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == tipoFormulario)
                {
                    form.BringToFront(); // Lleva el formulario existente al frente
                    return;
                }
            }

            // Si no se encuentra el formulario, crea una nueva instancia
            Form nuevoFormulario = (Form)Activator.CreateInstance(tipoFormulario);
            nuevoFormulario.Show();
        }

        private void LimpiarCampos()
        {
            foreach (Control control in this.Controls)
            {
                // Limpiar TextBox
                if (control is TextBox txtIdCliente)
                {
                    txtIdCliente.Clear();
                }
    
                // Desmarcar CheckBox
                else if (control is CheckBox chkEstadoCliente)
                {
                    chkEstadoCliente.Checked = false;
                }
                // Restablecer DateTimePicker al valor de hoy
                else if (control is DateTimePicker dtpkFechaCliente)
                {
                    dtpkFechaCliente.Value = DateTime.Today;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            if (!cambiosRealizados)
            {
                // Si no hay cambios, regresa a la vista Main
                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
            }
            else
            {
                MessageBox.Show("No puedes regresar sin guardar o cancelar los cambios.");
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoCliente_Click(object sender, EventArgs e)
        {
            if (cambiosRealizados)
            {
                // Si hay cambios, marca como listo y vuelve a Main
                MessageBox.Show("Cambios registrados exitosamente.");
                cambiosRealizados = false; // Restablecemos cambiosRealizados

                AbrirFormularioUnico(typeof(Main));
                this.Close(); // Cierra la vista actual
            }
            else
            {
                MessageBox.Show("No hay cambios para registrar.");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                // Convertir el valor de DNI y Número a int
                if (!int.TryParse(txtDniCliente.Text, out int dni))
                {
                    MessageBox.Show("El DNI debe ser un número válido.");
                    return;
                }

                if (!int.TryParse(txtNumeroCliente.Text, out int numero))
                {
                    MessageBox.Show("El Número debe ser un valor numérico.");
                    return;
                }

                entCliente nuevoCliente = new entCliente
                {
                    razonSocial = txtNombreCliente.Text,
                    dni = dni, // Se asegura de que el DNI está asignado como número
                    numero = numero,
                    correo = txtCorreoCliente.Text,
                    fecRegCliente = dtpkFechaCliente.Value,
                    estCliente = chkEstadoCliente.Checked
                };

                using (SqlConnection conexion = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertaCliente", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Asegurarse de agregar todos los parámetros necesarios
                        cmd.Parameters.AddWithValue("@razonSocial", nuevoCliente.razonSocial);
                        cmd.Parameters.AddWithValue("@dni", nuevoCliente.dni); // Agregar el parámetro @dni
                        cmd.Parameters.AddWithValue("@numero", nuevoCliente.numero);
                        cmd.Parameters.AddWithValue("@correo", nuevoCliente.correo);
                        cmd.Parameters.AddWithValue("@fecRegCliente", nuevoCliente.fecRegCliente);
                        cmd.Parameters.AddWithValue("@estCliente", nuevoCliente.estCliente);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente agregado correctamente.");
                    }
                }

                CargarClientes(); // Recarga la lista de clientes
                LimpiarCampos(); // Vaciar los campos después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Debe ingresar un ID Cliente válido para editar.");
                    return;
                }

                if (!int.TryParse(txtIdCliente.Text, out int idCliente))
                {
                    MessageBox.Show("El ID Cliente debe ser un número válido.");
                    return;
                }

                // Convertir valores de DNI y Número
                if (!int.TryParse(txtDniCliente.Text, out int dni))
                {
                    MessageBox.Show("El DNI debe ser un número válido.");
                    return;
                }

                if (!int.TryParse(txtNumeroCliente.Text, out int numero))
                {
                    MessageBox.Show("El Número debe ser un valor numérico.");
                    return;
                }

                entCliente clienteModificado = new entCliente
                {
                    idCliente = idCliente,
                    razonSocial = txtNombreCliente.Text,
                    dni = dni,
                    numero = numero,
                    correo = txtCorreoCliente.Text,
                    fecRegCliente = dtpkFechaCliente.Value,
                    estCliente = chkEstadoCliente.Checked
                };

                logCliente.Instancia.EditaCliente(clienteModificado);
                MessageBox.Show("Cliente modificado correctamente.");
                CargarClientes(); // Recarga la lista de clientes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message);
            }
        }


        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(txtIdCliente.Text);
                logCliente.Instancia.DeshabilitarCliente(idCliente);
                MessageBox.Show("Cliente inhabilitado correctamente.");
                CargarClientes(); // Recarga la lista de clientes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inhabilitar cliente: " + ex.Message);
            }
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvClientes.ReadOnly = true;
            dtgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvClientes.AllowUserToAddRows = false;
        }

        private void txtDniCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = false;
        }
    }
}
