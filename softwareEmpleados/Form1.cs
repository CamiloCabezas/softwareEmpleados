namespace softwareEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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


    }
}