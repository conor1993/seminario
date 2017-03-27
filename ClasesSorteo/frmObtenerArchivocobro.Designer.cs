namespace ClasesSorteo
{
    partial class frmObtenerArchivocobro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cmbTipopago = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
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
            this.Panel1.SuspendLayout();
            this.grpbienechores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbienechores)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.cmbTipopago);
            this.Panel1.Controls.Add(this.label26);
            this.Panel1.Controls.Add(this.cmbtarjeta);
            this.Panel1.Controls.Add(this.label15);
            this.Panel1.Controls.Add(this.label25);
            this.Panel1.Controls.Add(this.cmbCuentacobro);
            this.Panel1.Controls.Add(this.grpbienechores);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(828, 503);
            this.Panel1.TabIndex = 9;
            // 
            // cmbTipopago
            // 
            this.cmbTipopago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbTipopago.FormattingEnabled = true;
            this.cmbTipopago.Location = new System.Drawing.Point(319, 34);
            this.cmbTipopago.Name = "cmbTipopago";
            this.cmbTipopago.Size = new System.Drawing.Size(271, 23);
            this.cmbTipopago.TabIndex = 57;
            this.cmbTipopago.SelectionChangeCommitted += new System.EventHandler(this.cmbTipopago_SelectionChangeCommitted);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(197, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 15);
            this.label26.TabIndex = 58;
            this.label26.Text = "Tipo de pago:";
            // 
            // cmbtarjeta
            // 
            this.cmbtarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbtarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbtarjeta.FormattingEnabled = true;
            this.cmbtarjeta.Location = new System.Drawing.Point(319, 117);
            this.cmbtarjeta.Name = "cmbtarjeta";
            this.cmbtarjeta.Size = new System.Drawing.Size(271, 23);
            this.cmbtarjeta.TabIndex = 55;
            this.cmbtarjeta.SelectionChangeCommitted += new System.EventHandler(this.cmbtarjeta_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(236, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 56;
            this.label15.Text = "Tarjeta:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(175, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 15);
            this.label25.TabIndex = 54;
            this.label25.Text = "Cuanta de cobro:";
            // 
            // cmbCuentacobro
            // 
            this.cmbCuentacobro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCuentacobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmbCuentacobro.FormattingEnabled = true;
            this.cmbCuentacobro.Location = new System.Drawing.Point(319, 76);
            this.cmbCuentacobro.Name = "cmbCuentacobro";
            this.cmbCuentacobro.Size = new System.Drawing.Size(271, 23);
            this.cmbCuentacobro.TabIndex = 53;
            this.cmbCuentacobro.SelectionChangeCommitted += new System.EventHandler(this.cmbCuentacobro_SelectionChangeCommitted);
            // 
            // grpbienechores
            // 
            this.grpbienechores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbienechores.Controls.Add(this.dgvbienechores);
            this.grpbienechores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbienechores.Location = new System.Drawing.Point(27, 169);
            this.grpbienechores.Name = "grpbienechores";
            this.grpbienechores.Size = new System.Drawing.Size(772, 309);
            this.grpbienechores.TabIndex = 6;
            this.grpbienechores.TabStop = false;
            this.grpbienechores.Text = "Bienechores";
            // 
            // dgvbienechores
            // 
            this.dgvbienechores.AllowUserToAddRows = false;
            this.dgvbienechores.AllowUserToDeleteRows = false;
            this.dgvbienechores.AllowUserToOrderColumns = true;
            this.dgvbienechores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvbienechores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Format = "N2";
            this.clmCantidadDonacion.DefaultCellStyle = dataGridViewCellStyle2;
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
            // frmObtenerArchivocobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 503);
            this.Controls.Add(this.Panel1);
            this.Name = "frmObtenerArchivocobro";
            this.Text = "Pendientes de pago";
            this.Load += new System.EventHandler(this.frmObtenerArchivocobro_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.grpbienechores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbienechores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox grpbienechores;
        private System.Windows.Forms.DataGridView dgvbienechores;
        private System.Windows.Forms.ComboBox cmbCuentacobro;
        internal System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbtarjeta;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTipopago;
        internal System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadDonacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContrato;
    }
}