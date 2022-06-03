namespace FormsTP3
{
    partial class RegistroDePagos
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltvListaGestiones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.PlaceholderText = "Buscar";
            this.txtbBuscar.Size = new System.Drawing.Size(126, 23);
            this.txtbBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(60, 232);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(122, 41);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Registrar Pago";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Historial de Pago";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
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
            this.ltvListaGestiones.Location = new System.Drawing.Point(47, 61);
            this.ltvListaGestiones.Name = "ltvListaGestiones";
            this.ltvListaGestiones.Size = new System.Drawing.Size(376, 137);
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
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monto";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha del Pago";
            this.columnHeader4.Width = 100;
            // 
            // FrmGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 296);
            this.Controls.Add(this.ltvListaGestiones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbBuscar);
            this.Name = "FrmGestionar";
            this.Text = "GestionarPagos";
            this.Load += new System.EventHandler(this.FrmGestionarPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ltvListaGestiones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}