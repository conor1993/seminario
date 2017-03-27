namespace ClasesSorteo
{
    partial class frmPagoefectivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvBienechores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmfecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOtracantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienechores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtnombre.Location = new System.Drawing.Point(193, 42);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(271, 21);
            this.txtnombre.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(99, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "Bien hechor:";
            // 
            // dgvBienechores
            // 
            this.dgvBienechores.AllowUserToAddRows = false;
            this.dgvBienechores.AllowUserToDeleteRows = false;
            this.dgvBienechores.AllowUserToOrderColumns = true;
            this.dgvBienechores.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBienechores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBienechores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBienechores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienechores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBienechores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienechores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Apellido,
            this.Cantidad});
            this.dgvBienechores.Location = new System.Drawing.Point(12, 221);
            this.dgvBienechores.MultiSelect = false;
            this.dgvBienechores.Name = "dgvBienechores";
            this.dgvBienechores.ReadOnly = true;
            this.dgvBienechores.RowHeadersVisible = false;
            this.dgvBienechores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienechores.Size = new System.Drawing.Size(780, 197);
            this.dgvBienechores.TabIndex = 69;
            this.dgvBienechores.DoubleClick += new System.EventHandler(this.dgvBienechores_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // dtmfecha
            // 
            this.dtmfecha.CustomFormat = "MM";
            this.dtmfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dtmfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmfecha.Location = new System.Drawing.Point(193, 78);
            this.dtmfecha.Name = "dtmfecha";
            this.dtmfecha.Size = new System.Drawing.Size(271, 21);
            this.dtmfecha.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(31, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "Pago correspondiente :";
            // 
            // txtOtracantidad
            // 
            this.txtOtracantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtracantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtracantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtOtracantidad.Location = new System.Drawing.Point(193, 117);
            this.txtOtracantidad.MaxLength = 50;
            this.txtOtracantidad.Name = "txtOtracantidad";
            this.txtOtracantidad.Size = new System.Drawing.Size(271, 21);
            this.txtOtracantidad.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(119, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cantidad:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(193, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(150, 20);
            this.txtid.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(164, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "Id:";
            // 
            // frmPagoefectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtOtracantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtmfecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvBienechores);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtnombre);
            this.Name = "frmPagoefectivo";
            this.Text = "Pagos en efectivo";
            this.Load += new System.EventHandler(this.frmPagoefectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienechores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvBienechores;
        private System.Windows.Forms.DateTimePicker dtmfecha;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtOtracantidad;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label label1;
    }
}