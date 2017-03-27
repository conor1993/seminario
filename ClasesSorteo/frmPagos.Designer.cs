namespace ClasesSorteo
{
    partial class frmPagos
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
            this.dgvBienechores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmcumple = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienechores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBienechores
            // 
            this.dgvBienechores.AllowUserToAddRows = false;
            this.dgvBienechores.AllowUserToDeleteRows = false;
            this.dgvBienechores.AllowUserToOrderColumns = true;
            this.dgvBienechores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBienechores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBienechores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBienechores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBienechores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBienechores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBienechores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Referencia,
            this.Nombre,
            this.Apellido});
            this.dgvBienechores.Location = new System.Drawing.Point(12, 168);
            this.dgvBienechores.MultiSelect = false;
            this.dgvBienechores.Name = "dgvBienechores";
            this.dgvBienechores.ReadOnly = true;
            this.dgvBienechores.RowHeadersVisible = false;
            this.dgvBienechores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBienechores.Size = new System.Drawing.Size(812, 243);
            this.dgvBienechores.TabIndex = 69;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "Referencia";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
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
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(167, 51);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(146, 27);
            this.btnPago.TabIndex = 70;
            this.btnPago.Text = "Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "Realizar Pago:";
            // 
            // dtmcumple
            // 
            this.dtmcumple.CustomFormat = "MM yyyy";
            this.dtmcumple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.dtmcumple.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmcumple.Location = new System.Drawing.Point(263, 103);
            this.dtmcumple.Name = "dtmcumple";
            this.dtmcumple.Size = new System.Drawing.Size(114, 21);
            this.dtmcumple.TabIndex = 73;
            this.dtmcumple.ValueChanged += new System.EventHandler(this.dtmcumple_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Pagos Correspondientes al mes :";
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmcumple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.dgvBienechores);
            this.Name = "frmPagos";
            this.Text = "Catálogos de  Pagos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienechores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBienechores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button btnPago;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmcumple;
        internal System.Windows.Forms.Label label1;
    }
}