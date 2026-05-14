namespace prySilvaSP2v2
{
    partial class frmTema
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDTema = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblDCantante = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cmbCantantes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(488, 82);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(83, 37);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(488, 28);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(83, 37);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDTema
            // 
            this.lblDTema.AutoSize = true;
            this.lblDTema.Location = new System.Drawing.Point(35, 40);
            this.lblDTema.Name = "lblDTema";
            this.lblDTema.Size = new System.Drawing.Size(48, 13);
            this.lblDTema.TabIndex = 6;
            this.lblDTema.Text = "ID Tema";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(38, 146);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 12;
            this.lblLink.Text = "Link";
            // 
            // lblDCantante
            // 
            this.lblDCantante.AutoSize = true;
            this.lblDCantante.Location = new System.Drawing.Point(38, 199);
            this.lblDCantante.Name = "lblDCantante";
            this.lblDCantante.Size = new System.Drawing.Size(64, 13);
            this.lblDCantante.TabIndex = 13;
            this.lblDCantante.Text = "ID Cantante";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(110, 143);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(324, 20);
            this.txtLink.TabIndex = 14;
            // 
            // cmbCantantes
            // 
            this.cmbCantantes.FormattingEnabled = true;
            this.cmbCantantes.Location = new System.Drawing.Point(110, 196);
            this.cmbCantantes.Name = "cmbCantantes";
            this.cmbCantantes.Size = new System.Drawing.Size(100, 21);
            this.cmbCantantes.TabIndex = 15;
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 261);
            this.Controls.Add(this.cmbCantantes);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblDCantante);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDTema);
            this.Name = "frmTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Tema";
            this.Load += new System.EventHandler(this.frmTema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDTema;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblDCantante;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cmbCantantes;
    }
}