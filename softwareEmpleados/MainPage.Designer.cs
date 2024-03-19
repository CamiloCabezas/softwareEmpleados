namespace softwareEmpleados
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textNombre = new TextBox();
            textEmpresa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonCrear = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 42);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento De Clientes";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(125, 127);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(207, 23);
            textNombre.TabIndex = 1;
            // 
            // textEmpresa
            // 
            textEmpresa.Location = new Point(125, 179);
            textEmpresa.Name = "textEmpresa";
            textEmpresa.Size = new Size(207, 23);
            textEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 131);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 183);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 4;
            label3.Text = "Empresa";
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(135, 250);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(68, 24);
            buttonCrear.TabIndex = 5;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(237, 250);
            button1.Name = "button1";
            button1.Size = new Size(68, 24);
            button1.TabIndex = 7;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(393, 165);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(buttonCrear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textEmpresa);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textEmpresa;
        private Label label2;
        private Label label3;
        private Button buttonCrear;
        private Button button1;
        private DataGridView dataGridView1;
    }
}