namespace FormsTP4
{
    partial class FrmRegistroDePagos
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
            this.txtbBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnHistorialPagos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltvListaGestiones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(17, 20);
            this.txtbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.PlaceholderText = "Buscar";
            this.txtbBuscar.Size = new System.Drawing.Size(178, 31);
            this.txtbBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(86, 387);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(174, 68);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Registrar Pago";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnHistorialPagos
            // 
            this.btnHistorialPagos.Location = new System.Drawing.Point(404, 387);
            this.btnHistorialPagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistorialPagos.Name = "btnHistorialPagos";
            this.btnHistorialPagos.Size = new System.Drawing.Size(160, 68);
            this.btnHistorialPagos.TabIndex = 5;
            this.btnHistorialPagos.Text = "Historial de Pago";
            this.btnHistorialPagos.UseVisualStyleBackColor = true;
            this.btnHistorialPagos.Click += new System.EventHandler(this.btnHistorialPagos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de item Seleccionado";
            // 
            // ltvListaGestiones
            // 
            this.ltvListaGestiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvListaGestiones.FullRowSelect = true;
            this.ltvListaGestiones.HideSelection = false;
            this.ltvListaGestiones.Location = new System.Drawing.Point(67, 102);
            this.ltvListaGestiones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvListaGestiones.Name = "ltvListaGestiones";
            this.ltvListaGestiones.Size = new System.Drawing.Size(535, 226);
            this.ltvListaGestiones.TabIndex = 7;
            this.ltvListaGestiones.UseCompatibleStateImageBehavior = false;
            this.ltvListaGestiones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monto";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha del Pago";
            this.columnHeader4.Width = 200;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Haettenschweiler", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(629, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmRegistroDePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormsTP4.Properties.Resources.FondoMessiCR;
            this.ClientSize = new System.Drawing.Size(677, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ltvListaGestiones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHistorialPagos);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistroDePagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pagos";
            this.Load += new System.EventHandler(this.FrmGestionarPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnHistorialPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ltvListaGestiones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
    }
}