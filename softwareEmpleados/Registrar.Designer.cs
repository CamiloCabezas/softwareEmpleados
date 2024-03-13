namespace softwareEmpleados
{
    partial class Registrar
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PasswordLabel1 = new Label();
            PasswordLabel2 = new Label();
            textName = new TextBox();
            textApellido = new TextBox();
            textEmail = new TextBox();
            textPassword1 = new TextBox();
            textPassword2 = new TextBox();
            label5 = new Label();
            labelDanger = new Label();
            buttonCrear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 23);
            label1.Name = "label1";
            label1.Size = new Size(229, 40);
            label1.TabIndex = 0;
            label1.Text = "Solution Tech";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(224, 143);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 183);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 223);
            label4.Name = "label4";
            label4.Size = new Size(33, 16);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // PasswordLabel1
            // 
            PasswordLabel1.AutoSize = true;
            PasswordLabel1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel1.Location = new Point(224, 260);
            PasswordLabel1.Name = "PasswordLabel1";
            PasswordLabel1.Size = new Size(53, 16);
            PasswordLabel1.TabIndex = 4;
            PasswordLabel1.Text = "Password";
            // 
            // PasswordLabel2
            // 
            PasswordLabel2.AutoSize = true;
            PasswordLabel2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel2.Location = new Point(224, 290);
            PasswordLabel2.Name = "PasswordLabel2";
            PasswordLabel2.Size = new Size(57, 32);
            PasswordLabel2.TabIndex = 5;
            PasswordLabel2.Text = "Confirmar \r\nPassword\r\n";
            // 
            // textName
            // 
            textName.Location = new Point(305, 140);
            textName.Name = "textName";
            textName.Size = new Size(233, 23);
            textName.TabIndex = 6;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(305, 180);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(233, 23);
            textApellido.TabIndex = 7;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(305, 220);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(233, 23);
            textEmail.TabIndex = 8;
            // 
            // textPassword1
            // 
            textPassword1.Location = new Point(305, 257);
            textPassword1.Name = "textPassword1";
            textPassword1.Size = new Size(233, 23);
            textPassword1.TabIndex = 9;
            textPassword1.TextChanged += textPassword1_TextChanged;
            // 
            // textPassword2
            // 
            textPassword2.Location = new Point(305, 297);
            textPassword2.Name = "textPassword2";
            textPassword2.Size = new Size(233, 23);
            textPassword2.TabIndex = 10;
            textPassword2.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(224, 83);
            label5.Name = "label5";
            label5.Size = new Size(358, 16);
            label5.TabIndex = 11;
            label5.Text = "Aca podras crear un usuario que debe ser confirmado por el Admin";
            // 
            // labelDanger
            // 
            labelDanger.AutoSize = true;
            labelDanger.Location = new Point(324, 333);
            labelDanger.Name = "labelDanger";
            labelDanger.Size = new Size(0, 15);
            labelDanger.TabIndex = 12;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(369, 363);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(75, 23);
            buttonCrear.TabIndex = 13;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCrear);
            Controls.Add(labelDanger);
            Controls.Add(label5);
            Controls.Add(textPassword2);
            Controls.Add(textPassword1);
            Controls.Add(textEmail);
            Controls.Add(textApellido);
            Controls.Add(textName);
            Controls.Add(PasswordLabel2);
            Controls.Add(PasswordLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label PasswordLabel1;
        private Label PasswordLabel2;
        private TextBox textName;
        private TextBox textApellido;
        private TextBox textEmail;
        private TextBox textPassword1;
        private TextBox textPassword2;
        private Label label5;
        private Label labelDanger;
        private Button button1;
        private Button buttonCrear;
    }
}