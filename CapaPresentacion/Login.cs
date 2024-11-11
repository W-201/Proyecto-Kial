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
    public partial class Login : Form
    {
        // Credenciales fijas en el código
        private const string EMAIL = "edu@gmail.com";
        private const string PASSWORD = "123456";
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados por el usuario
            string emailIngresado = txtUsuario.Text;
            string passwordIngresado = txtContraseña.Text;

            // Verifica si coinciden con las credenciales almacenadas
            if (emailIngresado == EMAIL && passwordIngresado == PASSWORD)
            {
                MessageBox.Show("Inicio de sesión exitoso!");

                // Crea y muestra la instancia de la vista principal
                Main mainForm = new Main();
                mainForm.Show();

                // Oculta el formulario de login actual
                this.Hide();

                // Evento para cerrar la aplicación al cerrar Main
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
