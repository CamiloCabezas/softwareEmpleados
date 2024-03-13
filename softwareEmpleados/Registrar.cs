using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwareEmpleados
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            

        }
        string connectionString = "Data Source=DESKTOP-6MPUSM8;Initial Catalog=registroSoftware;Integrated Security=True";

        private void textPassword1_TextChanged(object sender, EventArgs e)
        {
            textPassword1.UseSystemPasswordChar = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textPassword2.UseSystemPasswordChar = true;
            var password = textPassword1.Text;
            var passwordConfirmed = textPassword2.Text;

            if (password != passwordConfirmed)
            {
                textPassword1.BackColor = Color.Red;
                textPassword2.BackColor = Color.Red;
                labelDanger.Text = "Las contraseñas deben coincidir";
                buttonCrear.Enabled = false;
            }
            else
            {
                textPassword1.BackColor = Color.Green;
                textPassword2.BackColor = Color.Green;
                labelDanger.Text = string.Empty;
                buttonCrear.Enabled = true;
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var validacionDatos = validaciones.DatosCompletos(textName.Text, textApellido.Text, textEmail.Text, textPassword1.Text, textPassword2.Text);
            if (validacionDatos)
            {
                buttonCrear.BackColor = Color.Green;
                SqlConnection conexion = new SqlConnection(connectionString);

                try
                {
                    conexion.Open();
                    SqlCommand comandoCreacion = new SqlCommand(@"INSERT INTO usuario(Nombre, Apellido, Email, Password, confirmado)
                                                              VALUES()");
                }
                this.Hide();
            }
            else
            {
                buttonCrear.BackColor = Color.Red;
                labelDanger.Text = "Te debe faltar por llenar algun espacio!";
            }


        }
    }

}
