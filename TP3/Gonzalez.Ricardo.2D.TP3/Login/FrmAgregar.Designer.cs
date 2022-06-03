namespace FormsTP3
{
    partial class FrmAgregar
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
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(100, 34);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.PlaceholderText = "Nombre";
            this.txtbNombre.Size = new System.Drawing.Size(146, 23);
            this.txtbNombre.TabIndex = 0;
            this.txtbNombre.Text = "riky";
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(100, 63);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.PlaceholderText = "Apellido";
            this.txtbApellido.Size = new System.Drawing.Size(146, 23);
            this.txtbApellido.TabIndex = 1;
            this.txtbApellido.Text = "gonza";
            // 
            // txtbDni
            // 
            this.txtbDni.Location = new System.Drawing.Point(100, 92);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.PlaceholderText = "DNI";
            this.txtbDni.Size = new System.Drawing.Size(146, 23);
            this.txtbDni.TabIndex = 2;
            this.txtbDni.Text = "35600032";
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(100, 121);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.PlaceholderText = "Edad";
            this.txtbEdad.Size = new System.Drawing.Size(146, 23);
            this.txtbEdad.TabIndex = 3;
            this.txtbEdad.Text = "33";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.RegistrarClick);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(100, 170);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(146, 23);
            this.cmbTipoUsuario.TabIndex = 6;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(100, 214);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(146, 23);
            this.cmbEquipo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese nombre de equipo";
            this.label1.Visible = false;
            // 
            // FrmAgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.txtbDni);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Name = "FrmAgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbDni;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label label1;
    }
}