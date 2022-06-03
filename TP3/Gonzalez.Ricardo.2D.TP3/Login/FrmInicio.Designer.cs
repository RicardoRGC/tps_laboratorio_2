namespace FormsTP3
{
    partial class FrmInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtguardar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(9, 53);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(110, 35);
            this.btnAgregarEquipo.TabIndex = 8;
            this.btnAgregarEquipo.Text = "Equipos";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 76);
            this.button2.TabIndex = 10;
            this.button2.Text = "Registrar Pagos \r\nEquipo\r\n y\r\n Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // txtguardar
            // 
            this.txtguardar.Location = new System.Drawing.Point(392, 270);
            this.txtguardar.Name = "txtguardar";
            this.txtguardar.Size = new System.Drawing.Size(106, 29);
            this.txtguardar.TabIndex = 11;
            this.txtguardar.Text = "Guardar xml";
            this.txtguardar.UseVisualStyleBackColor = true;
            this.txtguardar.Click += new System.EventHandler(this.txtguardar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(392, 224);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(106, 29);
            this.btnCargarDatos.TabIndex = 12;
            this.btnCargarDatos.Text = "CargarDatos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 334);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.txtguardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.button1);
            this.Name = "FrmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtguardar;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}
