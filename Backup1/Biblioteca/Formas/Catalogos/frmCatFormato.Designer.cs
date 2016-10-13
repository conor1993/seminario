namespace ClasesBiblioteca
{
    partial class frmCatFormato
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
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.Lblf = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dataFormato = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFormato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(12, 56);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(81, 20);
            this.lblFormato.TabIndex = 27;
            this.lblFormato.Text = "Formato:";
            // 
            // txtFormato
            // 
            this.txtFormato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormato.Location = new System.Drawing.Point(114, 53);
            this.txtFormato.MaxLength = 50;
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(468, 26);
            this.txtFormato.TabIndex = 28;
            // 
            // Lblf
            // 
            this.Lblf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblf.BackColor = System.Drawing.Color.Navy;
            this.Lblf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblf.ForeColor = System.Drawing.Color.White;
            this.Lblf.Location = new System.Drawing.Point(491, 9);
            this.Lblf.Name = "Lblf";
            this.Lblf.Size = new System.Drawing.Size(91, 21);
            this.Lblf.TabIndex = 29;
            this.Lblf.Text = "FORMATO";
            this.Lblf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lblf.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.dataFormato);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 85);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(581, 217);
            this.GroupBox1.TabIndex = 30;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Formatos Registrados";
            // 
            // dataFormato
            // 
            this.dataFormato.AllowUserToAddRows = false;
            this.dataFormato.AllowUserToDeleteRows = false;
            this.dataFormato.AllowUserToOrderColumns = true;
            this.dataFormato.AllowUserToResizeRows = false;
            this.dataFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFormato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFormato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFormato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Formato});
            this.dataFormato.Location = new System.Drawing.Point(6, 22);
            this.dataFormato.MultiSelect = false;
            this.dataFormato.Name = "dataFormato";
            this.dataFormato.ReadOnly = true;
            this.dataFormato.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataFormato.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataFormato.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFormato.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataFormato.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataFormato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFormato.Size = new System.Drawing.Size(568, 189);
            this.dataFormato.TabIndex = 0;
            this.dataFormato.DoubleClick += new System.EventHandler(this.dataFormato_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "Formato";
            this.Formato.FillWeight = 98.47716F;
            this.Formato.HeaderText = "Formato";
            this.Formato.MinimumWidth = 2;
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AllowPromptAsInput = false;
            this.txtCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(114, 10);
            this.txtCodigo.Mask = "999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PromptChar = ' ';
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ResetOnPrompt = false;
            this.txtCodigo.ResetOnSpace = false;
            this.txtCodigo.Size = new System.Drawing.Size(72, 26);
            this.txtCodigo.SkipLiterals = false;
            this.txtCodigo.TabIndex = 31;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(14, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 20);
            this.lbl.TabIndex = 32;
            this.lbl.Text = "Codigo:";
            // 
            // frmCatFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 305);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Lblf);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.lblFormato);
            this.Name = "frmCatFormato";
            this.Text = "Catálogo de Formato";
            this.Load += new System.EventHandler(this.frmCatFormato_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFormato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblFormato;
        internal System.Windows.Forms.TextBox txtFormato;
        internal System.Windows.Forms.Label Lblf;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dataFormato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        internal System.Windows.Forms.Label lbl;
    }
}