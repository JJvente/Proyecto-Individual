namespace FiltroSuavizado
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxFiltrada = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnGuardarBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltrada)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxFiltrada
            // 
            this.pictureBoxFiltrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFiltrada.Location = new System.Drawing.Point(380, 12);
            this.pictureBoxFiltrada.Name = "pictureBoxFiltrada";
            this.pictureBoxFiltrada.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxFiltrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFiltrada.TabIndex = 1;
            this.pictureBoxFiltrada.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(90, 380);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 40);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(295, 380);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(150, 40);
            this.btnAplicarFiltro.TabIndex = 3;
            this.btnAplicarFiltro.Text = "Aplicar Filtro 3x3";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // btnGuardarBD
            // 
            this.btnGuardarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBD.Location = new System.Drawing.Point(500, 380);
            this.btnGuardarBD.Name = "btnGuardarBD";
            this.btnGuardarBD.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarBD.TabIndex = 4;
            this.btnGuardarBD.Text = "Guardar en SGBD";
            this.btnGuardarBD.UseVisualStyleBackColor = true;
            this.btnGuardarBD.Click += new System.EventHandler(this.btnGuardarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 440);
            this.Controls.Add(this.btnGuardarBD);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pictureBoxFiltrada);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Suavizado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxFiltrada;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Button btnGuardarBD;
    }
}