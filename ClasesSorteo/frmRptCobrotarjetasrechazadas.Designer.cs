namespace ClasesSorteo
{
    partial class frmRptCobrotarjetasrechazadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbtarjeta = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbCuentacobro = new System.Windows.Forms.ComboBox();
            this.grpbienechores = new System.Windows.Forms.GroupBox();
            this.dgvbienechores = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadDonacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmdonaciones = new System.Windows.Forms.DateTimePicker();
            this.grpbienechores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbienechores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbtarjeta
            // 
            this.cmbtarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbtarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbtarjeta.FormattingEnabled = true;
            this.cmbtarjeta.Location = new System.Drawing.Point(320, 112);
            this.cmbtarjeta.Name = "cmbtarjeta";
            this.cmbtarjeta.Size = new System.Drawing.Size(271, 23);
            this.cmbtarjeta.TabIndex = 62;
            this.cmbtarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbtarjeta_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(237, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 63;
            this.label15.Text = "Tarjeta:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(176, 79);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 15);
            this.label25.TabIndex = 61;
            this.label25.Text = "Cuanta de cobro:";
            // 
            // cmbCuentacobro
            // 
            this.cmbCuentacobro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCuentacobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbCuentacobro.FormattingEnabled = true;
            this.cmbCuentacobro.Location = new System.Drawing.Point(320, 71);
            this.cmbCuentacobro.Name = "cmbCuentacobro";
            this.cmbCuentacobro.Size = new System.Drawing.Size(271, 23);
            this.cmbCuentacobro.TabIndex = 60;
            this.cmbCuentacobro.SelectionChangeCommitted += new System.EventHandler(this.cmbCuentacobro_SelectionChangeCommitted);
            // 
            // grpbienechores
            // 
            this.grpbienechores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbienechores.Controls.Add(this.dgvbienechores);
            this.grpbienechores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbienechores.Location = new System.Drawing.Point(28, 164);
            this.grpbienechores.Name = "grpbienechores";
            this.grpbienechores.Size = new System.Drawing.Size(772, 309);
            this.grpbienechores.TabIndex = 59;
            this.grpbienechores.TabStop = false;
            this.grpbienechores.Text = "Bienechores";
            // 
            // dgvbienechores
            // 
            this.dgvbienechores.AllowUserToAddRows = false;
            this.dgvbienechores.AllowUserToDeleteRows = false;
            this.dgvbienechores.AllowUserToOrderColumns = true;
            this.dgvbienechores.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvbienechores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvbienechores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbienechores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbienechores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbienechores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmNotarjeta,
            this.clmCantidadDonacion,
            this.clmContrato});
            this.dgvbienechores.Location = new System.Drawing.Point(15, 35);
            this.dgvbienechores.MultiSelect = false;
            this.dgvbienechores.Name = "dgvbienechores";
            this.dgvbienechores.ReadOnly = true;
            this.dgvbienechores.RowHeadersVisible = false;
            this.dgvbienechores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbienechores.Size = new System.Drawing.Size(748, 239);
            this.dgvbienechores.TabIndex = 65;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre";
            this.clmNombre.FillWeight = 40F;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmNotarjeta
            // 
            this.clmNotarjeta.DataPropertyName = "Notarjeta";
            this.clmNotarjeta.FillWeight = 15F;
            this.clmNotarjeta.HeaderText = "No Tarjeta";
            this.clmNotarjeta.Name = "clmNotarjeta";
            this.clmNotarjeta.ReadOnly = true;
            // 
            // clmCantidadDonacion
            // 
            this.clmCantidadDonacion.DataPropertyName = "CantidadDonacion";
            dataGridViewCellStyle16.Format = "N2";
            this.clmCantidadDonacion.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmCantidadDonacion.FillWeight = 15F;
            this.clmCantidadDonacion.HeaderText = "donacion";
            this.clmCantidadDonacion.Name = "clmCantidadDonacion";
            this.clmCantidadDonacion.ReadOnly = true;
            // 
            // clmContrato
            // 
            this.clmContrato.DataPropertyName = "Contrato";
            this.clmContrato.FillWeight = 30F;
            this.clmContrato.HeaderText = "contrato";
            this.clmContrato.Name = "clmContrato";
            this.clmContrato.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(117, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 83;
            this.label3.Text = "Correspondientes al mes :";
            // 
            // dtmdonaciones
            // 
            this.dtmdonaciones.CustomFormat = "MM yyyy";
            this.dtmdonaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dtmdonaciones.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmdonaciones.Location = new System.Drawing.Point(320, 34);
            this.dtmdonaciones.Name = "dtmdonaciones";
            this.dtmdonaciones.Size = new System.Drawing.Size(114, 21);
            this.dtmdonaciones.TabIndex = 82;
            this.dtmdonaciones.ValueChanged += new System.EventHandler(this.dtmdonaciones_ValueChanged);
            // 
            // frmRptCobrotarjetasrechazadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmdonaciones);
            this.Controls.Add(this.cmbtarjeta);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cmbCuentacobro);
            this.Controls.Add(this.grpbienechores);
            this.Name = "frmRptCobrotarjetasrechazadas";
            this.Text = "Pendientes de pago";
            this.Load += new System.EventHandler(this.frmRptCobrotarjetasrechazadas_Load);
            this.grpbienechores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbienechores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbtarjeta;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbCuentacobro;
        internal System.Windows.Forms.GroupBox grpbienechores;
        private System.Windows.Forms.DataGridView dgvbienechores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadDonacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrato;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmdonaciones;

    }
}