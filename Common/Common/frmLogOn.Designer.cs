namespace Common
{
    partial class frmLogOn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogOn));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogOn = new System.Windows.Forms.TextBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.txtConfCont = new System.Windows.Forms.TextBox();
            this.lbNvaCont = new System.Windows.Forms.Label();
            this.lblCambiarCont = new System.Windows.Forms.Label();
            this.txtNvaCont = new System.Windows.Forms.TextBox();
            this.lblConfCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(22, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingrese Usuario y Contraseña";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(353, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Usuario:";
            // 
            // txtLogOn
            // 
            this.txtLogOn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogOn.Location = new System.Drawing.Point(150, 69);
            this.txtLogOn.Name = "txtLogOn";
            this.txtLogOn.Size = new System.Drawing.Size(128, 21);
            this.txtLogOn.TabIndex = 1;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.Color.Maroon;
            this.lblCont.Location = new System.Drawing.Point(66, 106);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(76, 15);
            this.lblCont.TabIndex = 15;
            this.lblCont.Text = "Contraseña:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Blue;
            this.btnAceptar.Location = new System.Drawing.Point(298, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 54);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPassw
            // 
            this.txtPassw.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassw.Location = new System.Drawing.Point(150, 103);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '*';
            this.txtPassw.Size = new System.Drawing.Size(128, 21);
            this.txtPassw.TabIndex = 2;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(308, 137);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(95, 15);
            this.lblNuevoUsuario.TabIndex = 4;
            this.lblNuevoUsuario.Text = "Nuevo Ususario";
            this.lblNuevoUsuario.Visible = false;
            this.lblNuevoUsuario.Click += new System.EventHandler(this.lblNuevoUsuario_Click);
            // 
            // txtConfCont
            // 
            this.txtConfCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfCont.Location = new System.Drawing.Point(150, 168);
            this.txtConfCont.Name = "txtConfCont";
            this.txtConfCont.PasswordChar = '*';
            this.txtConfCont.Size = new System.Drawing.Size(128, 21);
            this.txtConfCont.TabIndex = 16;
            this.txtConfCont.Visible = false;
            // 
            // lbNvaCont
            // 
            this.lbNvaCont.AutoSize = true;
            this.lbNvaCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNvaCont.ForeColor = System.Drawing.Color.Maroon;
            this.lbNvaCont.Location = new System.Drawing.Point(28, 140);
            this.lbNvaCont.Name = "lbNvaCont";
            this.lbNvaCont.Size = new System.Drawing.Size(114, 15);
            this.lbNvaCont.TabIndex = 17;
            this.lbNvaCont.Text = "Nueva Contraseña:";
            this.lbNvaCont.Visible = false;
            this.lbNvaCont.Click += new System.EventHandler(this.lblConfCont_Click);
            // 
            // lblCambiarCont
            // 
            this.lblCambiarCont.AutoSize = true;
            this.lblCambiarCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambiarCont.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarCont.ForeColor = System.Drawing.Color.Maroon;
            this.lblCambiarCont.Location = new System.Drawing.Point(296, 152);
            this.lblCambiarCont.Name = "lblCambiarCont";
            this.lblCambiarCont.Size = new System.Drawing.Size(123, 15);
            this.lblCambiarCont.TabIndex = 18;
            this.lblCambiarCont.Text = "Cambiar Contraseña";
            this.lblCambiarCont.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNvaCont
            // 
            this.txtNvaCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvaCont.Location = new System.Drawing.Point(150, 137);
            this.txtNvaCont.Name = "txtNvaCont";
            this.txtNvaCont.PasswordChar = '*';
            this.txtNvaCont.Size = new System.Drawing.Size(128, 21);
            this.txtNvaCont.TabIndex = 19;
            this.txtNvaCont.Visible = false;
            // 
            // lblConfCont
            // 
            this.lblConfCont.AutoSize = true;
            this.lblConfCont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfCont.ForeColor = System.Drawing.Color.Maroon;
            this.lblConfCont.Location = new System.Drawing.Point(7, 171);
            this.lblConfCont.Name = "lblConfCont";
            this.lblConfCont.Size = new System.Drawing.Size(136, 15);
            this.lblConfCont.TabIndex = 20;
            this.lblConfCont.Text = "Confirmar Contraseña:";
            this.lblConfCont.Visible = false;
            this.lblConfCont.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmLogOn
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(430, 185);
            this.ControlBox = false;
            this.Controls.Add(this.txtNvaCont);
            this.Controls.Add(this.lblConfCont);
            this.Controls.Add(this.lblCambiarCont);
            this.Controls.Add(this.txtConfCont);
            this.Controls.Add(this.lbNvaCont);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.txtLogOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticar Usuario";
            this.Load += new System.EventHandler(this.frmLogOn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogOn;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtConfCont;
        private System.Windows.Forms.Label lbNvaCont;
        private System.Windows.Forms.Label lblCambiarCont;
        private System.Windows.Forms.TextBox txtNvaCont;
        private System.Windows.Forms.Label lblConfCont;
    }
}