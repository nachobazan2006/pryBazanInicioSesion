namespace pryBazanInicioSesion
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            txtContraseñaConfirmada = new TextBox();
            lblConfirmar = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 150);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(47, 99);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 39);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(47, 194);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(239, 39);
            txtContraseña.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(233, 379);
            button1.Name = "button1";
            button1.Size = new Size(113, 42);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(txtContraseñaConfirmada);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblConfirmar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(100, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 450);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(17, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 42);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaConfirmada
            // 
            txtContraseñaConfirmada.Location = new Point(47, 305);
            txtContraseñaConfirmada.Name = "txtContraseñaConfirmada";
            txtContraseñaConfirmada.Size = new Size(239, 39);
            txtContraseñaConfirmada.TabIndex = 5;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(47, 256);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(250, 32);
            lblConfirmar.TabIndex = 4;
            lblConfirmar.Text = "Confirmar contraseña";
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(603, 541);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicioSesion";
            Text = "Inicio de sesion ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnSalir;
        private TextBox txtContraseñaConfirmada;
        private Label lblConfirmar;
    }
}
