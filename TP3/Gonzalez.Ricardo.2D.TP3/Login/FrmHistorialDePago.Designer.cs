namespace FormsTP3
{
    partial class FrmHistorialDePago
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
            this.rtbListadeRegistros = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbListadeRegistros
            // 
            this.rtbListadeRegistros.Location = new System.Drawing.Point(12, 12);
            this.rtbListadeRegistros.Name = "rtbListadeRegistros";
            this.rtbListadeRegistros.Size = new System.Drawing.Size(353, 373);
            this.rtbListadeRegistros.TabIndex = 0;
            this.rtbListadeRegistros.Text = "";
            // 
            // FrmHistorialDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 409);
            this.Controls.Add(this.rtbListadeRegistros);
            this.Name = "FrmHistorialDePago";
            this.Text = "FrmListaRegistroPago";
            this.Load += new System.EventHandler(this.FrmListaRegistroPago_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListadeRegistros;
    }
}