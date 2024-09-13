namespace AppLogin
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
            btnAceptar = new Button();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(308, 531);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 49);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += button1_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(308, 445);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(275, 43);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(308, 338);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(275, 43);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 289);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 396);
            label2.Name = "label2";
            label2.Size = new Size(151, 37);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(452, 531);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 82);
            label3.Name = "label3";
            label3.Size = new Size(142, 50);
            label3.TabIndex = 6;
            label3.Text = "INICIO";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Logo;
            ClientSize = new Size(900, 899);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Label label3;
    }
}
