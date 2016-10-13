namespace ClasesBiblioteca
{
    partial class frmInvLibros
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tabcDatosAd = new System.Windows.Forms.TabControl();
            this.tabFoto = new System.Windows.Forms.TabPage();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.btnBuscarPortada = new System.Windows.Forms.Button();
            this.tabObserv = new System.Windows.Forms.TabPage();
            this.btnContraPortada = new System.Windows.Forms.Button();
            this.picContraportada = new System.Windows.Forms.PictureBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataLibros = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.Materia = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.labe = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.txtEjemplares = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpasillo = new System.Windows.Forms.MaskedTextBox();
            this.txtestante = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grbClasificacion = new System.Windows.Forms.GroupBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.cmbRama = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTematica = new System.Windows.Forms.ComboBox();
            this.chkIlustrado = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.chkSoloConsulta = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.tabcDatosAd.SuspendLayout();
            this.tabFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.tabObserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContraportada)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbClasificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.tabcDatosAd);
            this.Panel1.Controls.Add(this.lblestado);
            this.Panel1.Controls.Add(this.groupBox2);
            this.Panel1.Controls.Add(this.groupBox3);
            this.Panel1.Controls.Add(this.groupBox1);
            this.Panel1.Controls.Add(this.grbClasificacion);
            this.Panel1.Controls.Add(this.chkIlustrado);
            this.Panel1.Controls.Add(this.txtCodigo);
            this.Panel1.Controls.Add(this.cmbEstatus);
            this.Panel1.Controls.Add(this.chkSoloConsulta);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(820, 694);
            this.Panel1.TabIndex = 2;
            // 
            // tabcDatosAd
            // 
            this.tabcDatosAd.Controls.Add(this.tabFoto);
            this.tabcDatosAd.Controls.Add(this.tabObserv);
            this.tabcDatosAd.Location = new System.Drawing.Point(582, 449);
            this.tabcDatosAd.Name = "tabcDatosAd";
            this.tabcDatosAd.SelectedIndex = 0;
            this.tabcDatosAd.Size = new System.Drawing.Size(203, 237);
            this.tabcDatosAd.TabIndex = 68;
            // 
            // tabFoto
            // 
            this.tabFoto.Controls.Add(this.picPortada);
            this.tabFoto.Controls.Add(this.btnBuscarPortada);
            this.tabFoto.Location = new System.Drawing.Point(4, 22);
            this.tabFoto.Name = "tabFoto";
            this.tabFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoto.Size = new System.Drawing.Size(195, 211);
            this.tabFoto.TabIndex = 0;
            this.tabFoto.Text = "Portada";
            this.tabFoto.UseVisualStyleBackColor = true;
            // 
            // picPortada
            // 
            this.picPortada.Location = new System.Drawing.Point(0, 0);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(195, 178);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPortada.TabIndex = 44;
            this.picPortada.TabStop = false;
            // 
            // btnBuscarPortada
            // 
            this.btnBuscarPortada.Location = new System.Drawing.Point(3, 184);
            this.btnBuscarPortada.Name = "btnBuscarPortada";
            this.btnBuscarPortada.Size = new System.Drawing.Size(75, 24);
            this.btnBuscarPortada.TabIndex = 21;
            this.btnBuscarPortada.Text = "Cargar foto";
            this.btnBuscarPortada.UseVisualStyleBackColor = true;
            this.btnBuscarPortada.Click += new System.EventHandler(this.btnBuscarPortada_Click);
            // 
            // tabObserv
            // 
            this.tabObserv.Controls.Add(this.btnContraPortada);
            this.tabObserv.Controls.Add(this.picContraportada);
            this.tabObserv.Location = new System.Drawing.Point(4, 22);
            this.tabObserv.Name = "tabObserv";
            this.tabObserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabObserv.Size = new System.Drawing.Size(195, 211);
            this.tabObserv.TabIndex = 1;
            this.tabObserv.Text = "Contraportada";
            this.tabObserv.UseVisualStyleBackColor = true;
            // 
            // btnContraPortada
            // 
            this.btnContraPortada.Location = new System.Drawing.Point(3, 187);
            this.btnContraPortada.Name = "btnContraPortada";
            this.btnContraPortada.Size = new System.Drawing.Size(75, 24);
            this.btnContraPortada.TabIndex = 65;
            this.btnContraPortada.Text = "Cargar foto";
            this.btnContraPortada.UseVisualStyleBackColor = true;
            this.btnContraPortada.Click += new System.EventHandler(this.btnContraPortada_Click);
            // 
            // picContraportada
            // 
            this.picContraportada.Location = new System.Drawing.Point(0, 0);
            this.picContraportada.Name = "picContraportada";
            this.picContraportada.Size = new System.Drawing.Size(195, 181);
            this.picContraportada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContraportada.TabIndex = 64;
            this.picContraportada.TabStop = false;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(419, 18);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(135, 20);
            this.lblestado.TabIndex = 67;
            this.lblestado.Text = "Estado de libro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataLibros);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 191);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros";
            // 
            // dataLibros
            // 
            this.dataLibros.AllowUserToAddRows = false;
            this.dataLibros.AllowUserToDeleteRows = false;
            this.dataLibros.AllowUserToOrderColumns = true;
            this.dataLibros.AllowUserToResizeRows = false;
            this.dataLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLibros.Location = new System.Drawing.Point(26, 32);
            this.dataLibros.MultiSelect = false;
            this.dataLibros.Name = "dataLibros";
            this.dataLibros.ReadOnly = true;
            this.dataLibros.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataLibros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLibros.Size = new System.Drawing.Size(506, 150);
            this.dataLibros.TabIndex = 20;
            this.dataLibros.DoubleClick += new System.EventHandler(this.dataLibros_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numero);
            this.groupBox3.Controls.Add(this.txtNumero);
            this.groupBox3.Controls.Add(this.txtMateria);
            this.groupBox3.Controls.Add(this.Materia);
            this.groupBox3.Controls.Add(this.cmbFormato);
            this.groupBox3.Controls.Add(this.labe);
            this.groupBox3.Controls.Add(this.txtIsbn);
            this.groupBox3.Controls.Add(this.lblIsbn);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.txtTitulo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmbAutor);
            this.groupBox3.Controls.Add(this.txtEjemplares);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbEditorial);
            this.groupBox3.Controls.Add(this.txtEdicion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtAño);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbPais);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 245);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(476, 198);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(76, 20);
            this.numero.TabIndex = 72;
            this.numero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(558, 198);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(204, 26);
            this.txtNumero.TabIndex = 12;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(93, 195);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(350, 26);
            this.txtMateria.TabIndex = 6;
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materia.Location = new System.Drawing.Point(7, 195);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(74, 20);
            this.Materia.TabIndex = 70;
            this.Materia.Text = "Materia:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFormato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(575, 22);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(188, 28);
            this.cmbFormato.TabIndex = 8;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe.Location = new System.Drawing.Point(461, 22);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(81, 20);
            this.labe.TabIndex = 68;
            this.labe.Text = "Formato:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(93, 28);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(170, 26);
            this.txtIsbn.TabIndex = 1;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            this.txtIsbn.Leave += new System.EventHandler(this.txtIsbn_Leave);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(11, 26);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(49, 20);
            this.lblIsbn.TabIndex = 62;
            this.lblIsbn.Text = "Isbn:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(93, 60);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(670, 26);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 61;
            this.label15.Text = "Ejemplares:";
            // 
            // cmbAutor
            // 
            this.cmbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(93, 92);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(350, 28);
            this.cmbAutor.TabIndex = 3;
            this.cmbAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAutor_KeyPress);
            this.cmbAutor.Leave += new System.EventHandler(this.cmbAutor_Leave);
            // 
            // txtEjemplares
            // 
            this.txtEjemplares.AllowPromptAsInput = false;
            this.txtEjemplares.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtEjemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplares.Location = new System.Drawing.Point(671, 158);
            this.txtEjemplares.Mask = "999999";
            this.txtEjemplares.Name = "txtEjemplares";
            this.txtEjemplares.PromptChar = ' ';
            this.txtEjemplares.ReadOnly = true;
            this.txtEjemplares.ResetOnPrompt = false;
            this.txtEjemplares.ResetOnSpace = false;
            this.txtEjemplares.Size = new System.Drawing.Size(72, 26);
            this.txtEjemplares.SkipLiterals = false;
            this.txtEjemplares.TabIndex = 11;
            this.txtEjemplares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEjemplares.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Autor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(619, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "Año:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(592, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Edición:";
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(93, 126);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(350, 28);
            this.cmbEditorial.TabIndex = 4;
            this.cmbEditorial.Leave += new System.EventHandler(this.cmbEditorial_Leave);
            // 
            // txtEdicion
            // 
            this.txtEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(671, 94);
            this.txtEdicion.MaxLength = 50;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(91, 26);
            this.txtEdicion.TabIndex = 9;
            this.txtEdicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Editorial:";
            // 
            // txtAño
            // 
            this.txtAño.AllowPromptAsInput = false;
            this.txtAño.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(671, 126);
            this.txtAño.Mask = "9999";
            this.txtAño.Name = "txtAño";
            this.txtAño.PromptChar = ' ';
            this.txtAño.ResetOnPrompt = false;
            this.txtAño.ResetOnSpace = false;
            this.txtAño.Size = new System.Drawing.Size(72, 26);
            this.txtAño.SkipLiterals = false;
            this.txtAño.TabIndex = 10;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAño.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(93, 160);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(350, 28);
            this.cmbPais.TabIndex = 5;
            this.cmbPais.Leave += new System.EventHandler(this.cmbPais_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtpasillo);
            this.groupBox1.Controls.Add(this.txtestante);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtnivel);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(619, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 126);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicación";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 49;
            this.label16.Text = "Pasillo:";
            // 
            // txtpasillo
            // 
            this.txtpasillo.AllowPromptAsInput = false;
            this.txtpasillo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtpasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasillo.Location = new System.Drawing.Point(90, 25);
            this.txtpasillo.Mask = "999999";
            this.txtpasillo.Name = "txtpasillo";
            this.txtpasillo.PromptChar = ' ';
            this.txtpasillo.ResetOnPrompt = false;
            this.txtpasillo.ResetOnSpace = false;
            this.txtpasillo.Size = new System.Drawing.Size(65, 26);
            this.txtpasillo.SkipLiterals = false;
            this.txtpasillo.TabIndex = 15;
            this.txtpasillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpasillo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtestante
            // 
            this.txtestante.AllowPromptAsInput = false;
            this.txtestante.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestante.Location = new System.Drawing.Point(90, 59);
            this.txtestante.Mask = "999999";
            this.txtestante.Name = "txtestante";
            this.txtestante.PromptChar = ' ';
            this.txtestante.ResetOnPrompt = false;
            this.txtestante.ResetOnSpace = false;
            this.txtestante.Size = new System.Drawing.Size(65, 26);
            this.txtestante.SkipLiterals = false;
            this.txtestante.TabIndex = 16;
            this.txtestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtestante.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "Estante:";
            // 
            // txtnivel
            // 
            this.txtnivel.AllowPromptAsInput = false;
            this.txtnivel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel.Location = new System.Drawing.Point(90, 90);
            this.txtnivel.Mask = "999999";
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.PromptChar = ' ';
            this.txtnivel.ResetOnPrompt = false;
            this.txtnivel.ResetOnSpace = false;
            this.txtnivel.Size = new System.Drawing.Size(65, 26);
            this.txtnivel.SkipLiterals = false;
            this.txtnivel.TabIndex = 17;
            this.txtnivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnivel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "Nivel:";
            // 
            // grbClasificacion
            // 
            this.grbClasificacion.Controls.Add(this.maskedTextBox5);
            this.grbClasificacion.Controls.Add(this.cmbRama);
            this.grbClasificacion.Controls.Add(this.label11);
            this.grbClasificacion.Controls.Add(this.maskedTextBox6);
            this.grbClasificacion.Controls.Add(this.label12);
            this.grbClasificacion.Controls.Add(this.cmbTematica);
            this.grbClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClasificacion.Location = new System.Drawing.Point(15, 315);
            this.grbClasificacion.Name = "grbClasificacion";
            this.grbClasificacion.Size = new System.Drawing.Size(559, 115);
            this.grbClasificacion.TabIndex = 62;
            this.grbClasificacion.TabStop = false;
            this.grbClasificacion.Text = "Clasificación";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.AllowPromptAsInput = false;
            this.maskedTextBox5.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(121, 25);
            this.maskedTextBox5.Mask = "999999";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.PromptChar = ' ';
            this.maskedTextBox5.ResetOnPrompt = false;
            this.maskedTextBox5.ResetOnSpace = false;
            this.maskedTextBox5.Size = new System.Drawing.Size(72, 26);
            this.maskedTextBox5.SkipLiterals = false;
            this.maskedTextBox5.TabIndex = 50;
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox5.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbRama
            // 
            this.cmbRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRama.FormattingEnabled = true;
            this.cmbRama.Location = new System.Drawing.Point(199, 25);
            this.cmbRama.Name = "cmbRama";
            this.cmbRama.Size = new System.Drawing.Size(350, 28);
            this.cmbRama.TabIndex = 13;
            this.cmbRama.Leave += new System.EventHandler(this.cmbRama_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Rama:";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.AllowPromptAsInput = false;
            this.maskedTextBox6.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.Location = new System.Drawing.Point(121, 68);
            this.maskedTextBox6.Mask = "999999";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.PromptChar = ' ';
            this.maskedTextBox6.ResetOnPrompt = false;
            this.maskedTextBox6.ResetOnSpace = false;
            this.maskedTextBox6.Size = new System.Drawing.Size(72, 26);
            this.maskedTextBox6.SkipLiterals = false;
            this.maskedTextBox6.TabIndex = 53;
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox6.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Temática:";
            // 
            // cmbTematica
            // 
            this.cmbTematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTematica.FormattingEnabled = true;
            this.cmbTematica.Location = new System.Drawing.Point(199, 65);
            this.cmbTematica.Name = "cmbTematica";
            this.cmbTematica.Size = new System.Drawing.Size(350, 28);
            this.cmbTematica.TabIndex = 14;
            this.cmbTematica.Leave += new System.EventHandler(this.cmbTematica_Leave);
            // 
            // chkIlustrado
            // 
            this.chkIlustrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIlustrado.AutoSize = true;
            this.chkIlustrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIlustrado.Location = new System.Drawing.Point(211, 449);
            this.chkIlustrado.Name = "chkIlustrado";
            this.chkIlustrado.Size = new System.Drawing.Size(99, 24);
            this.chkIlustrado.TabIndex = 19;
            this.chkIlustrado.Text = "Ilustrado";
            this.chkIlustrado.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AllowPromptAsInput = false;
            this.txtCodigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(133, 12);
            this.txtCodigo.Mask = "999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PromptChar = ' ';
            this.txtCodigo.ResetOnPrompt = false;
            this.txtCodigo.ResetOnSpace = false;
            this.txtCodigo.Size = new System.Drawing.Size(72, 26);
            this.txtCodigo.SkipLiterals = false;
            this.txtCodigo.TabIndex = 100;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCodigo.GotFocus += new System.EventHandler(this.mtbId_GotFocus);
            this.txtCodigo.LostFocus += new System.EventHandler(this.mtbId_LostFocus);
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Location = new System.Drawing.Point(587, 12);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(188, 28);
            this.cmbEstatus.TabIndex = 7;
            // 
            // chkSoloConsulta
            // 
            this.chkSoloConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSoloConsulta.AutoSize = true;
            this.chkSoloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloConsulta.Location = new System.Drawing.Point(15, 449);
            this.chkSoloConsulta.Name = "chkSoloConsulta";
            this.chkSoloConsulta.Size = new System.Drawing.Size(175, 24);
            this.chkSoloConsulta.TabIndex = 18;
            this.chkSoloConsulta.Text = "Exclusivo consulta";
            this.chkSoloConsulta.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Código:";
            // 
            // frmInvLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 694);
            this.Controls.Add(this.Panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvLibros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventario de Libros";
            this.Load += new System.EventHandler(this.frmInvLibros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInvLibros_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmInvLibros_KeyPress);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.tabcDatosAd.ResumeLayout(false);
            this.tabFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.tabObserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picContraportada)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLibros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbClasificacion.ResumeLayout(false);
            this.grbClasificacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckBox chkSoloConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtpasillo;
        private System.Windows.Forms.MaskedTextBox txtestante;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbClasificacion;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.ComboBox cmbRama;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTematica;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtEjemplares;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.MaskedTextBox txtAño;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPais;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEditorial;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.CheckBox chkIlustrado;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dataLibros;
        internal System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl tabcDatosAd;
        private System.Windows.Forms.TabPage tabFoto;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.Button btnBuscarPortada;
        private System.Windows.Forms.TabPage tabObserv;
        private System.Windows.Forms.Button btnContraPortada;
        private System.Windows.Forms.PictureBox picContraportada;
        internal System.Windows.Forms.ComboBox cmbFormato;
        internal System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox txtMateria;
        internal System.Windows.Forms.Label Materia;
        internal System.Windows.Forms.Label numero;
        private System.Windows.Forms.MaskedTextBox txtnivel;
        private System.Windows.Forms.TextBox txtNumero;


    }
}

