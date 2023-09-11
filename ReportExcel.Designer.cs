namespace Reporte_Exc_L
{
    partial class ReporteExcel
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
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PbExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(206, 59);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(87, 20);
            this.DtpFecha.TabIndex = 32;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label3.Location = new System.Drawing.Point(144, 194);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 19);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Exportar";
            // 
            // CbTipo
            // 
            this.CbTipo.BackColor = System.Drawing.Color.White;
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Items.AddRange(new object[] {
            "E",
            "I"});
            this.CbTipo.Location = new System.Drawing.Point(225, 133);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(121, 21);
            this.CbTipo.TabIndex = 30;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label2.Location = new System.Drawing.Point(110, 133);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 19);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Tipo Instructor";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(144, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 22);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Reporte control de curso";
            // 
            // PbExcel
            // 
            this.PbExcel.BackColor = System.Drawing.Color.Transparent;
            this.PbExcel.Image = global::Reporte_Exc_L.Properties.Resources.excel;
            this.PbExcel.Location = new System.Drawing.Point(225, 177);
            this.PbExcel.Name = "PbExcel";
            this.PbExcel.Size = new System.Drawing.Size(78, 63);
            this.PbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbExcel.TabIndex = 27;
            this.PbExcel.TabStop = false;
            this.PbExcel.Click += new System.EventHandler(this.PbExcel_Click);
            // 
            // ReporteExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reporte_Exc_L.Properties.Resources.codioful_formerly_gradienta_bKESVqfxass_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PbExcel);
            this.Name = "ReporteExcel";
            this.Text = "Reporte excel";         
            ((System.ComponentModel.ISupportInitialize)(this.PbExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker DtpFecha;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox CbTipo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PbExcel;
    }
}

