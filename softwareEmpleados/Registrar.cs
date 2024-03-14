using Microsoft.Data.SqlClient;
using softwareEmpleados.Models;
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
        string connectionString = "Server=DESKTOP-6MPUSM8;Database=registroSoftware;Integrated Security=True;TrustServerCertificate=true";
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



                User usuario = new User();
                usuario.Nombre = textName.Text;
                usuario.Apellido = textApellido.Text;
                usuario.Email = textEmail.Text;
                usuario.Password = validaciones.HashPassword(textPassword1.Text).ToString();


                    conexion.Open();

                    SqlCommand comandoCreacion = new SqlCommand(@"INSERT INTO usuario (Nombre, Apellido, Email, Password, confirmado)
                                              VALUES (@Nombre, @Apellido, @Email, @Password, @Confirmado)", conexion);
                    // Agregar parámetros al comando SQL
                    comandoCreacion.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comandoCreacion.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    comandoCreacion.Parameters.AddWithValue("@Email", usuario.Email);
                    comandoCreacion.Parameters.AddWithValue("@Password", usuario.Password); // Asumiendo que Confirmado es una propiedad de usuario
                    comandoCreacion.Parameters.AddWithValue("@Confirmado", false);
                // Ejecutar el comando SQL
                comandoCreacion.ExecuteNonQuery();

                conexion.Close();
                this.Close();
            }
            else
            {
                buttonCrear.BackColor = Color.Red;
                labelDanger.Text = "Te debe faltar por llenar algun espacio!";
            }


        }
    }

}
