using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorComprobanteDeVenta : Form
    {
        private bool cambiosRealizados = false; // Indicador de cambios en dtgv
        public MantenedorComprobanteDeVenta()
        {
            InitializeComponent();
            // Suscribimos el evento de cambio de celda en dtvinsumo
            dtgvComprobantesVentas.CellValueChanged += dtgvComprobantesVentas_CellValueChanged;
        }
        // Evento para detectar cambios en dtvinsumo
        private void dtgvComprobantesVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarComprobante_Click(object sender, EventArgs e)
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

        private void btnCancelarComprobante_Click(object sender, EventArgs e)
        {
            // Cancela los cambios y vuelve a Main
            cambiosRealizados = false; // Restablecemos cambiosRealizados
            MessageBox.Show("Los cambios han sido cancelados.");

            AbrirFormularioUnico(typeof(Main));
            this.Close(); // Cierra la vista actual
        }

        private void btnListoComprobante_Click(object sender, EventArgs e)
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
    }
}
