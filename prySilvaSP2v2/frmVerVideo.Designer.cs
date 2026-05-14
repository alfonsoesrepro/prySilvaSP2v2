namespace prySilvaSP2v2
{
    partial class frmVerVideo
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdVerVideo = new System.Windows.Forms.Button();
            this.txtIDTema = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblCantante = new System.Windows.Forms.Label();
            this.cmbCantantes = new System.Windows.Forms.ComboBox();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.grpBrowser = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(113, 99);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(429, 20);
            this.txtLink.TabIndex = 22;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(38, 102);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 21;
            this.lblLink.Text = "Link";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(600, 84);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(83, 37);
            this.cmdSalir.TabIndex = 20;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdVerVideo
            // 
            this.cmdVerVideo.Location = new System.Drawing.Point(600, 30);
            this.cmdVerVideo.Name = "cmdVerVideo";
            this.cmdVerVideo.Size = new System.Drawing.Size(83, 37);
            this.cmdVerVideo.TabIndex = 19;
            this.cmdVerVideo.Text = "&Ver Video";
            this.cmdVerVideo.UseVisualStyleBackColor = true;
            this.cmdVerVideo.Click += new System.EventHandler(this.cmdVerVideo_Click);
            // 
            // txtIDTema
            // 
            this.txtIDTema.Location = new System.Drawing.Point(113, 39);
            this.txtIDTema.Name = "txtIDTema";
            this.txtIDTema.Size = new System.Drawing.Size(100, 20);
            this.txtIDTema.TabIndex = 17;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(38, 72);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 16;
            this.lblTema.Text = "Tema";
            // 
            // lblCantante
            // 
            this.lblCantante.AutoSize = true;
            this.lblCantante.Location = new System.Drawing.Point(38, 42);
            this.lblCantante.Name = "lblCantante";
            this.lblCantante.Size = new System.Drawing.Size(50, 13);
            this.lblCantante.TabIndex = 15;
            this.lblCantante.Text = "Cantante";
            // 
            // cmbCantantes
            // 
            this.cmbCantantes.FormattingEnabled = true;
            this.cmbCantantes.Location = new System.Drawing.Point(113, 38);
            this.cmbCantantes.Name = "cmbCantantes";
            this.cmbCantantes.Size = new System.Drawing.Size(174, 21);
            this.cmbCantantes.TabIndex = 23;
            this.cmbCantantes.SelectedIndexChanged += new System.EventHandler(this.cmbCantantes_SelectedIndexChanged);
            // 
            // cmbTemas
            // 
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Location = new System.Drawing.Point(113, 68);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(324, 21);
            this.cmbTemas.TabIndex = 24;
            this.cmbTemas.SelectedIndexChanged += new System.EventHandler(this.cmbTemas_SelectedIndexChanged);
            // 
            // grpBrowser
            // 
            this.grpBrowser.Location = new System.Drawing.Point(12, 127);
            this.grpBrowser.Name = "grpBrowser";
            this.grpBrowser.Size = new System.Drawing.Size(687, 311);
            this.grpBrowser.TabIndex = 25;
            this.grpBrowser.TabStop = false;
            // 
            // frmVerVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.grpBrowser);
            this.Controls.Add(this.cmbTemas);
            this.Controls.Add(this.cmbCantantes);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdVerVideo);
            this.Controls.Add(this.txtIDTema);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblCantante);
            this.Name = "frmVerVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Video";
            this.Load += new System.EventHandler(this.frmVerVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdVerVideo;
        private System.Windows.Forms.TextBox txtIDTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblCantante;
        private System.Windows.Forms.ComboBox cmbCantantes;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.GroupBox grpBrowser;
    }
}