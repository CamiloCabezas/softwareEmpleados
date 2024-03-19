using Microsoft.Data.SqlClient;
using softwareEmpleados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwareEmpleados
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-6MPUSM8;Database=registroSoftware;Integrated Security=True;TrustServerCertificate=true";

        public void ChargeData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string consulta = "SELECT * FROM clientes";
            SqlDataAdapter Adapter = new SqlDataAdapter(consulta, connection);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var validacion = validaciones.DatosCompletos(textNombre.Text, textEmpresa.Text);

            if (validacion)
            {
                SqlConnection connection = new SqlConnection(connectionString);

                Client Cliente = new Client();
                Cliente.Nombre = textNombre.Text;
                Cliente.Empresa = textEmpresa.Text;
                Cliente.DateAdd = DateTime.Now;

                connection.Open();

                SqlCommand AddClient = new SqlCommand(@"INSERT INTO clientes(Nombre, Empresa, DateAdd)
                                                        VALUES(@Nombre, @Empresa, @DateAdd)", connection);

                AddClient.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
                AddClient.Parameters.AddWithValue("@Empresa", Cliente.Empresa);
                AddClient.Parameters.AddWithValue("@DateAdd", Cliente.DateAdd);
                AddClient.ExecuteNonQuery();
                MessageBox.Show("Cliente Creado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

            }
            ChargeData();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            ChargeData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textEmpresa.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Obtener el valor de la celda en la columna específica
                object cellValue = dataGridView1.Rows[rowIndex].Cells["Id"].Value;
                if (cellValue != null)
                {
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    SqlCommand DeleteCliente = new SqlCommand(@"DELETE FROM clientes
                                                                WHERE Id = @Id", connection);

                    DeleteCliente.Parameters.AddWithValue("@Id", cellValue.ToString());
                    DeleteCliente.ExecuteNonQuery();
                    MessageBox.Show("Cliente ELiminado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                    ChargeData();
                }
            }
        }
    }
}
