namespace softwareEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Usuario = new Label();
            label2 = new Label();
            textUser = new TextBox();
            textPassword = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8bd34dc1_8eda_4bd6_999a_82a1697aba3a;
            pictureBox1.Location = new Point(65, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(516, 104);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 1;
            label1.Text = "Ingresar";
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(429, 160);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 2;
            Usuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 199);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // textUser
            // 
            textUser.Location = new Point(516, 152);
            textUser.Name = "textUser";
            textUser.Size = new Size(200, 23);
            textUser.TabIndex = 4;
            textUser.Text = "Pepito123";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(516, 191);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(200, 23);
            textPassword.TabIndex = 5;
            textPassword.Text = "******";
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 272);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 6;
            label3.Text = "¿Aun no estas Registrado?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(609, 272);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(114, 66);
            label4.Name = "label4";
            label4.Size = new Size(192, 35);
            label4.TabIndex = 8;
            label4.Text = "Solution Tech";
            // 
            // button1
            // 
            button1.Location = new Point(516, 229);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 9;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textPassword);
            Controls.Add(textUser);
            Controls.Add(label2);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Usuario;
        private Label label2;
        private TextBox textUser;
        private TextBox textPassword;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
    }
}