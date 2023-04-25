namespace PryStreamLeer_Cantallops
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.txtGrabar = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(261, 281);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(26, 284);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(190, 20);
            this.txtDato.TabIndex = 12;
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(26, 76);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.ReadOnly = true;
            this.rtbTexto.Size = new System.Drawing.Size(190, 168);
            this.rtbTexto.TabIndex = 11;
            this.rtbTexto.Text = "";
            // 
            // txtGrabar
            // 
            this.txtGrabar.Location = new System.Drawing.Point(26, 24);
            this.txtGrabar.Name = "txtGrabar";
            this.txtGrabar.Size = new System.Drawing.Size(190, 20);
            this.txtGrabar.TabIndex = 10;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(261, 24);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(261, 76);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 391);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.txtGrabar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.TextBox txtGrabar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLeer;
    }
}

