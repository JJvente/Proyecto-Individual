namespace textura
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.pbImagenResaltada = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnAnalizarTextura = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblSegmentada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenResaltada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();

            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(20, 40);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(400, 300);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;

            this.pbImagenResaltada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenResaltada.Location = new System.Drawing.Point(440, 40);
            this.pbImagenResaltada.Name = "pbImagenResaltada";
            this.pbImagenResaltada.Size = new System.Drawing.Size(400, 300);
            this.pbImagenResaltada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenResaltada.TabIndex = 5;
            this.pbImagenResaltada.TabStop = false;

            this.btnCargarImagen.Location = new System.Drawing.Point(20, 360);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(120, 40);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);

            this.btnAnalizarTextura.Enabled = false;
            this.btnAnalizarTextura.Location = new System.Drawing.Point(150, 360);
            this.btnAnalizarTextura.Name = "btnAnalizarTextura";
            this.btnAnalizarTextura.Size = new System.Drawing.Size(120, 40);
            this.btnAnalizarTextura.TabIndex = 2;
            this.btnAnalizarTextura.Text = "Analizar Textura";
            this.btnAnalizarTextura.UseVisualStyleBackColor = true;
            this.btnAnalizarTextura.Click += new System.EventHandler(this.BtnAnalizarTextura_Click);

            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(290, 370);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(550, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado: Ninguno";

            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(20, 420);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(820, 140);
            this.dgvHistorial.TabIndex = 4;

            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(20, 20);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(81, 13);
            this.lblOriginal.TabIndex = 6;
            this.lblOriginal.Text = "Imagen Original";

            this.lblSegmentada.AutoSize = true;
            this.lblSegmentada.Location = new System.Drawing.Point(440, 20);
            this.lblSegmentada.Name = "lblSegmentada";
            this.lblSegmentada.Size = new System.Drawing.Size(102, 13);
            this.lblSegmentada.TabIndex = 7;
            this.lblSegmentada.Text = "Textura Resaltada";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 581);
            this.Controls.Add(this.lblSegmentada);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.pbImagenResaltada);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAnalizarTextura);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbImagen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clasificador de Texturas Satelitales";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenResaltada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbImagenResaltada;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnAnalizarTextura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblSegmentada;
    }
}