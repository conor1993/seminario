namespace ClasesSorteo
{
    partial class frmRptDonacionesmesuales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmdonaciones = new System.Windows.Forms.DateTimePicker();
            this.dgvdonaciones = new System.Windows.Forms.DataGridView();
            this.Campaña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(216, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 81;
            this.label3.Text = "Correspondientes al mes :";
            // 
            // dtmdonaciones
            // 
            this.dtmdonaciones.CustomFormat = "MM yyyy";
            this.dtmdonaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dtmdonaciones.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmdonaciones.Location = new System.Drawing.Point(415, 34);
            this.dtmdonaciones.Name = "dtmdonaciones";
            this.dtmdonaciones.Size = new System.Drawing.Size(114, 21);
            this.dtmdonaciones.TabIndex = 80;
            this.dtmdonaciones.ValueChanged += new System.EventHandler(this.dtmdonaciones_ValueChanged);
            // 
            // dgvdonaciones
            // 
            this.dgvdonaciones.AllowUserToAddRows = false;
            this.dgvdonaciones.AllowUserToDeleteRows = false;
            this.dgvdonaciones.AllowUserToOrderColumns = true;
            this.dgvdonaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdonaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdonaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdonaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdonaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvdonaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdonaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campaña,
            this.Pago,
            this.Cantidad});
            this.dgvdonaciones.Location = new System.Drawing.Point(26, 84);
            this.dgvdonaciones.MultiSelect = false;
            this.dgvdonaciones.Name = "dgvdonaciones";
            this.dgvdonaciones.ReadOnly = true;
            this.dgvdonaciones.RowHeadersVisible = false;
            this.dgvdonaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdonaciones.Size = new System.Drawing.Size(740, 220);
            this.dgvdonaciones.TabIndex = 79;
            // 
            // Campaña
            // 
            this.Campaña.DataPropertyName = "Campaña";
            this.Campaña.HeaderText = "Campaña";
            this.Campaña.Name = "Campaña";
            this.Campaña.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // frmRptDonacionesmesuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmdonaciones);
            this.Controls.Add(this.dgvdonaciones);
            this.Name = "frmRptDonacionesmesuales";
            this.Text = "Reporte de donaciones";
            this.Load += new System.EventHandler(this.frmRptDonacionesmesuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmdonaciones;
        private System.Windows.Forms.DataGridView dgvdonaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campaña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;

    }
}