namespace ClasesSeminario
{
    partial class frmCapturaAsistencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.dgvParrocos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.tabcDatosAd = new System.Windows.Forms.TabControl();
            this.tabFoto = new System.Windows.Forms.TabPage();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.tabObserv = new System.Windows.Forms.TabPage();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstudios = new System.Windows.Forms.TextBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblApeMaterno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAutorizacion = new System.Windows.Forms.GroupBox();
            this.cmbParroco = new System.Windows.Forms.ComboBox();
            this.cmbParroquia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParrocos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabcDatosAd.SuspendLayout();
            this.tabFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabObserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.grbAutorizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEvento);
            this.panel1.Controls.Add(this.dgvParrocos);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grbAutorizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 602);
            this.panel1.TabIndex = 9;
            // 
            // cmbEvento
            // 
            this.cmbEvento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEvento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(115, 12);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(857, 23);
            this.cmbEvento.TabIndex = 1;
            this.cmbEvento.SelectedIndexChanged += new System.EventHandler(this.cmbEvento_SelectedIndexChanged);
            // 
            // dgvParrocos
            // 
            this.dgvParrocos.AllowUserToAddRows = false;
            this.dgvParrocos.AllowUserToDeleteRows = false;
            this.dgvParrocos.AllowUserToResizeRows = false;
            this.dgvParrocos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParrocos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParrocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParrocos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParrocos.Location = new System.Drawing.Point(519, 53);
            this.dgvParrocos.Name = "dgvParrocos";
            this.dgvParrocos.ReadOnly = true;
            this.dgvParrocos.RowHeadersVisible = false;
            this.dgvParrocos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParrocos.Size = new System.Drawing.Size(453, 90);
            this.dgvParrocos.TabIndex = 2;
            this.dgvParrocos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParrocos_CellClick);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Evento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txteMail);
            this.groupBox2.Controls.Add(this.tabcDatosAd);
            this.groupBox2.Controls.Add(this.txtApeMaterno);
            this.groupBox2.Controls.Add(this.txtApePaterno);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.dtpFechaNac);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEstudios);
            this.groupBox2.Controls.Add(this.cmbSeccion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvParticipantes);
            this.groupBox2.Controls.Add(this.cmbEquipo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbCiudad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFacebook);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.lblApeMaterno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.txtDomicilio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 441);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del participante";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "e-Mail:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txteMail
            // 
            this.txteMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteMail.Location = new System.Drawing.Point(187, 344);
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(306, 22);
            this.txteMail.TabIndex = 12;
            // 
            // tabcDatosAd
            // 
            this.tabcDatosAd.Controls.Add(this.tabFoto);
            this.tabcDatosAd.Controls.Add(this.tabObserv);
            this.tabcDatosAd.Location = new System.Drawing.Point(499, 214);
            this.tabcDatosAd.Name = "tabcDatosAd";
            this.tabcDatosAd.SelectedIndex = 0;
            this.tabcDatosAd.Size = new System.Drawing.Size(455, 222);
            this.tabcDatosAd.TabIndex = 16;
            // 
            // tabFoto
            // 
            this.tabFoto.Controls.Add(this.picFoto);
            this.tabFoto.Controls.Add(this.btnBuscarFoto);
            this.tabFoto.Location = new System.Drawing.Point(4, 29);
            this.tabFoto.Name = "tabFoto";
            this.tabFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoto.Size = new System.Drawing.Size(447, 189);
            this.tabFoto.TabIndex = 0;
            this.tabFoto.Text = "Fotografía";
            this.tabFoto.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(6, 6);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(315, 177);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 44;
            this.picFoto.TabStop = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(327, 116);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(114, 67);
            this.btnBuscarFoto.TabIndex = 17;
            this.btnBuscarFoto.Text = "Cargar foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // tabObserv
            // 
            this.tabObserv.Controls.Add(this.txtObservaciones);
            this.tabObserv.Location = new System.Drawing.Point(4, 29);
            this.tabObserv.Name = "tabObserv";
            this.tabObserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabObserv.Size = new System.Drawing.Size(447, 189);
            this.tabObserv.TabIndex = 1;
            this.tabObserv.Text = "Observaciones";
            this.tabObserv.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(3, 3);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(441, 183);
            this.txtObservaciones.TabIndex = 15;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApeMaterno.BackColor = System.Drawing.Color.Turquoise;
            this.txtApeMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMaterno.Location = new System.Drawing.Point(637, 45);
            this.txtApeMaterno.MaxLength = 50;
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(313, 22);
            this.txtApeMaterno.TabIndex = 3;
            this.txtApeMaterno.TextChanged += new System.EventHandler(this.txtApeMaterno_TextChanged);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApePaterno.BackColor = System.Drawing.Color.Turquoise;
            this.txtApePaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePaterno.Location = new System.Drawing.Point(325, 45);
            this.txtApePaterno.MaxLength = 50;
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(306, 22);
            this.txtApePaterno.TabIndex = 2;
            this.txtApePaterno.TextChanged += new System.EventHandler(this.txtApePaterno_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.Turquoise;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(325, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Apellido paterno:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Edad:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(395, 182);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(35, 26);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.TabStop = false;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = " ";
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(187, 182);
            this.dtpFechaNac.MaxDate = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(132, 26);
            this.dtpFechaNac.TabIndex = 5;
            this.dtpFechaNac.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha de nacimiento:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Grado de estudios:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEstudios
            // 
            this.txtEstudios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudios.Location = new System.Drawing.Point(187, 376);
            this.txtEstudios.Name = "txtEstudios";
            this.txtEstudios.Size = new System.Drawing.Size(306, 22);
            this.txtEstudios.TabIndex = 13;
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(822, 183);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(132, 24);
            this.cmbSeccion.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(731, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Sección:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Equipo:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            this.dgvParticipantes.AllowUserToResizeRows = false;
            this.dgvParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdParticipante,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.FechaNacim,
            this.aceptado,
            this.Evento});
            this.dgvParticipantes.Location = new System.Drawing.Point(6, 77);
            this.dgvParticipantes.MultiSelect = false;
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.ReadOnly = true;
            this.dgvParticipantes.RowHeadersVisible = false;
            this.dgvParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipantes.Size = new System.Drawing.Size(948, 99);
            this.dgvParticipantes.TabIndex = 4;
            this.dgvParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellClick);
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(510, 183);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(215, 24);
            this.cmbEquipo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ciudad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(187, 246);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(306, 24);
            this.cmbCiudad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Facebook:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacebook.Location = new System.Drawing.Point(187, 312);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(306, 22);
            this.txtFacebook.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cel.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(361, 280);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(132, 22);
            this.txtCelular.TabIndex = 10;
            // 
            // lblApeMaterno
            // 
            this.lblApeMaterno.AutoSize = true;
            this.lblApeMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeMaterno.Location = new System.Drawing.Point(637, 22);
            this.lblApeMaterno.Name = "lblApeMaterno";
            this.lblApeMaterno.Size = new System.Drawing.Size(149, 20);
            this.lblApeMaterno.TabIndex = 18;
            this.lblApeMaterno.Text = "Apellido materno:";
            this.lblApeMaterno.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Teléfonos   Casa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(187, 280);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(187, 214);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(306, 22);
            this.txtDomicilio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Domicilio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbAutorizacion
            // 
            this.grbAutorizacion.Controls.Add(this.cmbParroco);
            this.grbAutorizacion.Controls.Add(this.cmbParroquia);
            this.grbAutorizacion.Controls.Add(this.label8);
            this.grbAutorizacion.Controls.Add(this.label7);
            this.grbAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAutorizacion.Location = new System.Drawing.Point(12, 44);
            this.grbAutorizacion.Name = "grbAutorizacion";
            this.grbAutorizacion.Size = new System.Drawing.Size(501, 99);
            this.grbAutorizacion.TabIndex = 2;
            this.grbAutorizacion.TabStop = false;
            this.grbAutorizacion.Text = "Autorización";
            // 
            // cmbParroco
            // 
            this.cmbParroco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParroco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParroco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbParroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParroco.FormattingEnabled = true;
            this.cmbParroco.Location = new System.Drawing.Point(103, 59);
            this.cmbParroco.Name = "cmbParroco";
            this.cmbParroco.Size = new System.Drawing.Size(390, 24);
            this.cmbParroco.TabIndex = 3;
            this.cmbParroco.Validating += new System.ComponentModel.CancelEventHandler(this.cmbParroco_Validating);
            // 
            // cmbParroquia
            // 
            this.cmbParroquia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParroquia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParroquia.BackColor = System.Drawing.Color.White;
            this.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbParroquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParroquia.FormattingEnabled = true;
            this.cmbParroquia.Location = new System.Drawing.Point(103, 25);
            this.cmbParroquia.Name = "cmbParroquia";
            this.cmbParroquia.Size = new System.Drawing.Size(390, 24);
            this.cmbParroquia.TabIndex = 1;
            this.cmbParroquia.SelectedIndexChanged += new System.EventHandler(this.cmbParroquia_SelectedIndexChanged);
            this.cmbParroquia.Validating += new System.ComponentModel.CancelEventHandler(this.cmbParroquia_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Parroquia:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Párroco:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IdParticipante
            // 
            this.IdParticipante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdParticipante.DataPropertyName = "IdParticipante";
            this.IdParticipante.HeaderText = "IdParticipante";
            this.IdParticipante.Name = "IdParticipante";
            this.IdParticipante.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoPaterno.DataPropertyName = "ApellidoPaterno";
            this.ApellidoPaterno.FillWeight = 120F;
            this.ApellidoPaterno.HeaderText = "ApellidoPaterno";
            this.ApellidoPaterno.MinimumWidth = 10;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoMaterno.DataPropertyName = "ApellidoMaterno";
            this.ApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // FechaNacim
            // 
            this.FechaNacim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaNacim.DataPropertyName = "FechaNacim";
            this.FechaNacim.HeaderText = "FechaNacim";
            this.FechaNacim.Name = "FechaNacim";
            this.FechaNacim.ReadOnly = true;
            // 
            // aceptado
            // 
            this.aceptado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aceptado.DataPropertyName = "aceptado";
            this.aceptado.HeaderText = "aceptado";
            this.aceptado.Name = "aceptado";
            this.aceptado.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.DataPropertyName = "Evento";
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Visible = false;
            this.Evento.Width = 90;
            // 
            // frmCapturaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "frmCapturaAsistencia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Captura de participantes en eventos del seminario";
            this.Load += new System.EventHandler(this.frmCapturaAsistencia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCapturaAsistencia_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCapturaAsistencia_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParrocos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabcDatosAd.ResumeLayout(false);
            this.tabFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabObserv.ResumeLayout(false);
            this.tabObserv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.grbAutorizacion.ResumeLayout(false);
            this.grbAutorizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbParroquia;
        private System.Windows.Forms.ComboBox cmbParroco;
        private System.Windows.Forms.DataGridView dgvParrocos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbAutorizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstudios;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblApeMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txteMail;
        private System.Windows.Forms.TabControl tabcDatosAd;
        private System.Windows.Forms.TabPage tabFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.TabPage tabObserv;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacim;
        private System.Windows.Forms.DataGridViewTextBoxColumn aceptado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;

    }
}

