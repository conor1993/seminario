﻿namespace ClasesBiblioteca
{
    partial class frmCatTematicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblEstatus = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRama = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.Panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Código:";
            // 
            // LblEstatus
            // 
            this.LblEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstatus.BackColor = System.Drawing.Color.Navy;
            this.LblEstatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstatus.ForeColor = System.Drawing.Color.White;
            this.LblEstatus.Location = new System.Drawing.Point(563, 16);
            this.LblEstatus.Name = "LblEstatus";
            this.LblEstatus.Size = new System.Drawing.Size(91, 21);
            this.LblEstatus.TabIndex = 0;
            this.LblEstatus.Text = "ESTATUS";
            this.LblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblEstatus.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 119);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(564, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.DataGrid);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 160);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(660, 190);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Temáticas Registradas";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.ClmNombre,
            this.clmSeccion,
            this.clmRama});
            this.DataGrid.Location = new System.Drawing.Point(6, 22);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(647, 162);
            this.DataGrid.TabIndex = 6;
            this.DataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGrid_CellFormatting);
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick);
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClmCodigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmCodigo.FillWeight = 50F;
            this.ClmCodigo.HeaderText = "Código";
            this.ClmCodigo.Name = "ClmCodigo";
            this.ClmCodigo.ReadOnly = true;
            // 
            // ClmNombre
            // 
            this.ClmNombre.DataPropertyName = "Nombre";
            this.ClmNombre.FillWeight = 250F;
            this.ClmNombre.HeaderText = "Nombre";
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            // 
            // clmSeccion
            // 
            this.clmSeccion.DataPropertyName = "Seccion";
            this.clmSeccion.HeaderText = "Sección";
            this.clmSeccion.Name = "clmSeccion";
            this.clmSeccion.ReadOnly = true;
            // 
            // clmRama
            // 
            this.clmRama.DataPropertyName = "Rama";
            this.clmRama.HeaderText = "Rama";
            this.clmRama.Name = "clmRama";
            this.clmRama.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.groupBox2);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(684, 362);
            this.Panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbRama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbSeccion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LblEstatus);
            this.groupBox2.Controls.Add(this.mtbCodigo);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 151);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cmbRama
            // 
            this.cmbRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRama.FormattingEnabled = true;
            this.cmbRama.Location = new System.Drawing.Point(90, 85);
            this.cmbRama.Name = "cmbRama";
            this.cmbRama.Size = new System.Drawing.Size(300, 28);
            this.cmbRama.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Rama:";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(90, 51);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(300, 28);
            this.cmbSeccion.TabIndex = 2;
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sección:";
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.AllowPromptAsInput = false;
            this.mtbCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCodigo.Location = new System.Drawing.Point(90, 19);
            this.mtbCodigo.Mask = "999999";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.PromptChar = ' ';
            this.mtbCodigo.ReadOnly = true;
            this.mtbCodigo.ResetOnPrompt = false;
            this.mtbCodigo.ResetOnSpace = false;
            this.mtbCodigo.Size = new System.Drawing.Size(72, 26);
            this.mtbCodigo.SkipLiterals = false;
            this.mtbCodigo.TabIndex = 1;
            this.mtbCodigo.TabStop = false;
            this.mtbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmCatTematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.Panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmCatTematicas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálogo de Temáticas";
            this.Load += new System.EventHandler(this.frmCatSecciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCatSecciones_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCatSecciones_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblEstatus;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView DataGrid;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbRama;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRama;



    }
}
