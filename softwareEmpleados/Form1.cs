using Microsoft.Data.SqlClient;

namespace softwareEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-6MPUSM8;Database=registroSoftware;Integrated Security=True;TrustServerCertificate=true";

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // aca nos estamos haciendo referencia a la pagina principal que queremos que se esconda
            Registrar VentanaRegistrar = new Registrar();
            VentanaRegistrar.ShowDialog();
            this.Show(); // aca queremos es que la de VentanaRegistrar aparezca
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand getUser = new SqlCommand(@"SELECT * FROM usuario WHERE Nombre = @Nombre", connection);
                getUser.Parameters.AddWithValue("@Nombre", textUser.Text);

                using (SqlDataReader reader = getUser.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string password = reader["Password"].ToString();

                            if (password == validaciones.HashPassword(textPassword.Text))
                            {
                                this.Hide();
                                MainPage mainPage = new MainPage();
                                mainPage.ShowDialog();
                                this.Show();
                                return; // Salir del método después de iniciar sesión exitosamente
                            }
                        }
                        MessageBox.Show("La contraseña es incorrecta. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario no existe. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}