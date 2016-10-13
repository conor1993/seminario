<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.tsslServidor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslBaseDeDatos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslConexion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslEjercicio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsmiArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiEdiDeshacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiEdiCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiEdiCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiEdiPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmGenerales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatPaises = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParrocosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParroquiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmSeminario = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatParticipantes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmBiblioteca = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatRamas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatTematicas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatEditoriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatAutores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiCatLibros = New System.Windows.Forms.ToolStripMenuItem()
        Me.LectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSeminario = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRegistroDeAsistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiRptListaAsistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiParticipaciónEnEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiVenCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiVenMosaicoHoriz = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiVenMosaicoVert = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiVenOrganIconos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiVenAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssmiArchSesión = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchCambiarPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssmiArchCatEmpr = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchSelecEmpr = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssmiArchConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchConfGenerales = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchConfPlantillas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchConfUDI = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchSeguridad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem67 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem68 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem69 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem70 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssmiArchSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tmrFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.Location = New System.Drawing.Point(0, 670)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(984, 22)
        Me.Status.TabIndex = 4
        Me.Status.Text = "StatusStrip1"
        Me.Status.UseWaitCursor = True
        '
        'tsslServidor
        '
        Me.tsslServidor.AutoSize = False
        Me.tsslServidor.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslServidor.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslServidor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslServidor.Name = "tsslServidor"
        Me.tsslServidor.Size = New System.Drawing.Size(115, 17)
        Me.tsslServidor.Text = "Srv:"
        '
        'tsslBaseDeDatos
        '
        Me.tsslBaseDeDatos.AutoSize = False
        Me.tsslBaseDeDatos.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslBaseDeDatos.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslBaseDeDatos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslBaseDeDatos.Name = "tsslBaseDeDatos"
        Me.tsslBaseDeDatos.Size = New System.Drawing.Size(115, 17)
        Me.tsslBaseDeDatos.Text = "BD:"
        '
        'tsslUsuario
        '
        Me.tsslUsuario.AutoSize = False
        Me.tsslUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslUsuario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslUsuario.Name = "tsslUsuario"
        Me.tsslUsuario.Size = New System.Drawing.Size(115, 17)
        Me.tsslUsuario.Text = "Usr:"
        '
        'tsslConexion
        '
        Me.tsslConexion.AutoSize = False
        Me.tsslConexion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslConexion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslConexion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslConexion.Name = "tsslConexion"
        Me.tsslConexion.Size = New System.Drawing.Size(115, 17)
        Me.tsslConexion.Text = "Cnx:"
        '
        'tsslEjercicio
        '
        Me.tsslEjercicio.AutoSize = False
        Me.tsslEjercicio.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslEjercicio.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslEjercicio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslEjercicio.Name = "tsslEjercicio"
        Me.tsslEjercicio.Size = New System.Drawing.Size(115, 17)
        Me.tsslEjercicio.Text = "Ejer:"
        '
        'tsslVersion
        '
        Me.tsslVersion.AutoSize = False
        Me.tsslVersion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslVersion.Name = "tsslVersion"
        Me.tsslVersion.Size = New System.Drawing.Size(115, 17)
        Me.tsslVersion.Text = "Ver."
        '
        'tsslFecha
        '
        Me.tsslFecha.AutoSize = False
        Me.tsslFecha.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslFecha.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslFecha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslFecha.Name = "tsslFecha"
        Me.tsslFecha.Size = New System.Drawing.Size(115, 17)
        Me.tsslFecha.Text = "Fecha"
        '
        'tsslHora
        '
        Me.tsslHora.AutoSize = False
        Me.tsslHora.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslHora.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslHora.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslHora.Name = "tsslHora"
        Me.tsslHora.Size = New System.Drawing.Size(115, 17)
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 116)
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiArchivo, Me.tsmiEdicion, Me.CatálogosToolStripMenuItem, Me.tsmSeminario, Me.tsmiVentana})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.MdiWindowListItem = Me.tsmiVentana
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(984, 24)
        Me.MenuPrincipal.TabIndex = 15
        '
        'tsmiArchivo
        '
        Me.tsmiArchivo.Name = "tsmiArchivo"
        Me.tsmiArchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsmiArchivo.Tag = "O"
        Me.tsmiArchivo.Text = "&Archivo"
        '
        'tsmiEdicion
        '
        Me.tsmiEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiEdiDeshacer, Me.tssmiEdiCortar, Me.tssmiEdiCopiar, Me.tssmiEdiPegar})
        Me.tsmiEdicion.Name = "tsmiEdicion"
        Me.tsmiEdicion.Size = New System.Drawing.Size(58, 20)
        Me.tsmiEdicion.Tag = "O"
        Me.tsmiEdicion.Text = "&Edición"
        '
        'tssmiEdiDeshacer
        '
        Me.tssmiEdiDeshacer.Name = "tssmiEdiDeshacer"
        Me.tssmiEdiDeshacer.Size = New System.Drawing.Size(152, 22)
        Me.tssmiEdiDeshacer.Tag = "O"
        Me.tssmiEdiDeshacer.Text = "&Deshacer"
        '
        'tssmiEdiCortar
        '
        Me.tssmiEdiCortar.Name = "tssmiEdiCortar"
        Me.tssmiEdiCortar.Size = New System.Drawing.Size(152, 22)
        Me.tssmiEdiCortar.Tag = "O"
        Me.tssmiEdiCortar.Text = "Cor&tar"
        '
        'tssmiEdiCopiar
        '
        Me.tssmiEdiCopiar.Name = "tssmiEdiCopiar"
        Me.tssmiEdiCopiar.Size = New System.Drawing.Size(152, 22)
        Me.tssmiEdiCopiar.Tag = "O"
        Me.tssmiEdiCopiar.Text = "&Copiar"
        '
        'tssmiEdiPegar
        '
        Me.tssmiEdiPegar.Name = "tssmiEdiPegar"
        Me.tssmiEdiPegar.Size = New System.Drawing.Size(152, 22)
        Me.tssmiEdiPegar.Tag = "O"
        Me.tssmiEdiPegar.Text = "&Pegar"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmGenerales, Me.tssmSeminario, Me.tssmBiblioteca})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatálogosToolStripMenuItem.Text = "&Catálogos"
        '
        'tssmGenerales
        '
        Me.tssmGenerales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiCatPaises, Me.ParrocosToolStripMenuItem, Me.ParroquiasToolStripMenuItem, Me.FormatosToolStripMenuItem, Me.EstatusToolStripMenuItem})
        Me.tssmGenerales.Name = "tssmGenerales"
        Me.tssmGenerales.Size = New System.Drawing.Size(127, 22)
        Me.tssmGenerales.Text = "&Generales"
        '
        'tssmiCatPaises
        '
        Me.tssmiCatPaises.Name = "tssmiCatPaises"
        Me.tssmiCatPaises.Size = New System.Drawing.Size(130, 22)
        Me.tssmiCatPaises.Text = "&Paises"
        '
        'ParrocosToolStripMenuItem
        '
        Me.ParrocosToolStripMenuItem.Name = "ParrocosToolStripMenuItem"
        Me.ParrocosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ParrocosToolStripMenuItem.Text = "Parrocos"
        '
        'ParroquiasToolStripMenuItem
        '
        Me.ParroquiasToolStripMenuItem.Name = "ParroquiasToolStripMenuItem"
        Me.ParroquiasToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ParroquiasToolStripMenuItem.Text = "Parroquias"
        '
        'FormatosToolStripMenuItem
        '
        Me.FormatosToolStripMenuItem.Name = "FormatosToolStripMenuItem"
        Me.FormatosToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.FormatosToolStripMenuItem.Text = "Formatos"
        '
        'EstatusToolStripMenuItem
        '
        Me.EstatusToolStripMenuItem.Name = "EstatusToolStripMenuItem"
        Me.EstatusToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EstatusToolStripMenuItem.Text = "Estatus"
        '
        'tssmSeminario
        '
        Me.tssmSeminario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiCatEventos, Me.tssmiCatParticipantes})
        Me.tssmSeminario.Name = "tssmSeminario"
        Me.tssmSeminario.Size = New System.Drawing.Size(127, 22)
        Me.tssmSeminario.Text = "&Seminario"
        '
        'tssmiCatEventos
        '
        Me.tssmiCatEventos.Name = "tssmiCatEventos"
        Me.tssmiCatEventos.Size = New System.Drawing.Size(142, 22)
        Me.tssmiCatEventos.Text = "&Eventos"
        '
        'tssmiCatParticipantes
        '
        Me.tssmiCatParticipantes.Name = "tssmiCatParticipantes"
        Me.tssmiCatParticipantes.Size = New System.Drawing.Size(142, 22)
        Me.tssmiCatParticipantes.Text = "&Participantes"
        '
        'tssmBiblioteca
        '
        Me.tssmBiblioteca.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiCatRamas, Me.tssmiCatTematicas, Me.tssmiCatEditoriales, Me.tssmiCatAutores, Me.tssmiCatLibros, Me.LectoresToolStripMenuItem})
        Me.tssmBiblioteca.Name = "tssmBiblioteca"
        Me.tssmBiblioteca.Size = New System.Drawing.Size(127, 22)
        Me.tssmBiblioteca.Text = "&Biblioteca"
        '
        'tssmiCatRamas
        '
        Me.tssmiCatRamas.Name = "tssmiCatRamas"
        Me.tssmiCatRamas.Size = New System.Drawing.Size(128, 22)
        Me.tssmiCatRamas.Text = "&Ramas"
        '
        'tssmiCatTematicas
        '
        Me.tssmiCatTematicas.Name = "tssmiCatTematicas"
        Me.tssmiCatTematicas.Size = New System.Drawing.Size(128, 22)
        Me.tssmiCatTematicas.Text = "&Temáticas"
        '
        'tssmiCatEditoriales
        '
        Me.tssmiCatEditoriales.Name = "tssmiCatEditoriales"
        Me.tssmiCatEditoriales.Size = New System.Drawing.Size(128, 22)
        Me.tssmiCatEditoriales.Text = "&Editoriales"
        '
        'tssmiCatAutores
        '
        Me.tssmiCatAutores.Name = "tssmiCatAutores"
        Me.tssmiCatAutores.Size = New System.Drawing.Size(128, 22)
        Me.tssmiCatAutores.Text = "&Autores"
        '
        'tssmiCatLibros
        '
        Me.tssmiCatLibros.Name = "tssmiCatLibros"
        Me.tssmiCatLibros.Size = New System.Drawing.Size(128, 22)
        Me.tssmiCatLibros.Text = "&Libros"
        '
        'LectoresToolStripMenuItem
        '
        Me.LectoresToolStripMenuItem.Name = "LectoresToolStripMenuItem"
        Me.LectoresToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LectoresToolStripMenuItem.Text = "Lectores"
        '
        'tsmSeminario
        '
        Me.tsmSeminario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmEventos, Me.tssmReportes})
        Me.tsmSeminario.Name = "tsmSeminario"
        Me.tsmSeminario.Size = New System.Drawing.Size(72, 20)
        Me.tsmSeminario.Text = "&Seminario"
        '
        'tssmEventos
        '
        Me.tssmEventos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRegistroDeAsistencia})
        Me.tssmEventos.Name = "tssmEventos"
        Me.tssmEventos.Size = New System.Drawing.Size(120, 22)
        Me.tssmEventos.Text = "&Eventos"
        '
        'tsmiRegistroDeAsistencia
        '
        Me.tsmiRegistroDeAsistencia.Name = "tsmiRegistroDeAsistencia"
        Me.tsmiRegistroDeAsistencia.Size = New System.Drawing.Size(189, 22)
        Me.tsmiRegistroDeAsistencia.Text = "&Registro de Asistencia"
        '
        'tssmReportes
        '
        Me.tssmReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiRptListaAsistencia, Me.tssmiParticipaciónEnEventos})
        Me.tssmReportes.Name = "tssmReportes"
        Me.tssmReportes.Size = New System.Drawing.Size(120, 22)
        Me.tssmReportes.Text = "&Reportes"
        '
        'tssmiRptListaAsistencia
        '
        Me.tssmiRptListaAsistencia.Name = "tssmiRptListaAsistencia"
        Me.tssmiRptListaAsistencia.Size = New System.Drawing.Size(203, 22)
        Me.tssmiRptListaAsistencia.Text = "&Lista de Asistencia"
        '
        'tssmiParticipaciónEnEventos
        '
        Me.tssmiParticipaciónEnEventos.Name = "tssmiParticipaciónEnEventos"
        Me.tssmiParticipaciónEnEventos.Size = New System.Drawing.Size(203, 22)
        Me.tssmiParticipaciónEnEventos.Text = "Participación en Eventos"
        '
        'tsmiVentana
        '
        Me.tsmiVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiVenCascada, Me.tssmiVenMosaicoHoriz, Me.tssmiVenMosaicoVert, Me.tssmiVenOrganIconos, Me.tssmiVenAcercaDe})
        Me.tsmiVentana.Name = "tsmiVentana"
        Me.tsmiVentana.Size = New System.Drawing.Size(62, 20)
        Me.tsmiVentana.Tag = "O"
        Me.tsmiVentana.Text = "Ve&ntana"
        '
        'tssmiVenCascada
        '
        Me.tssmiVenCascada.Name = "tssmiVenCascada"
        Me.tssmiVenCascada.Size = New System.Drawing.Size(175, 22)
        Me.tssmiVenCascada.Tag = "O"
        Me.tssmiVenCascada.Text = "&Cascada"
        '
        'tssmiVenMosaicoHoriz
        '
        Me.tssmiVenMosaicoHoriz.Name = "tssmiVenMosaicoHoriz"
        Me.tssmiVenMosaicoHoriz.Size = New System.Drawing.Size(175, 22)
        Me.tssmiVenMosaicoHoriz.Tag = "O"
        Me.tssmiVenMosaicoHoriz.Text = "Mosaico &horizontal"
        '
        'tssmiVenMosaicoVert
        '
        Me.tssmiVenMosaicoVert.Name = "tssmiVenMosaicoVert"
        Me.tssmiVenMosaicoVert.Size = New System.Drawing.Size(175, 22)
        Me.tssmiVenMosaicoVert.Tag = "O"
        Me.tssmiVenMosaicoVert.Text = "Mosaico &vertical"
        '
        'tssmiVenOrganIconos
        '
        Me.tssmiVenOrganIconos.Name = "tssmiVenOrganIconos"
        Me.tssmiVenOrganIconos.Size = New System.Drawing.Size(175, 22)
        Me.tssmiVenOrganIconos.Tag = "O"
        Me.tssmiVenOrganIconos.Text = "&Organizar iconos"
        '
        'tssmiVenAcercaDe
        '
        Me.tssmiVenAcercaDe.Name = "tssmiVenAcercaDe"
        Me.tssmiVenAcercaDe.Size = New System.Drawing.Size(175, 22)
        Me.tssmiVenAcercaDe.Tag = "O"
        Me.tssmiVenAcercaDe.Text = "&Acerca de..."
        '
        'tssmiArchNuevo
        '
        Me.tssmiArchNuevo.Name = "tssmiArchNuevo"
        Me.tssmiArchNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tssmiArchNuevo.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchNuevo.Text = "&Nuevo"
        '
        'tssmiArchGuardar
        '
        Me.tssmiArchGuardar.Name = "tssmiArchGuardar"
        Me.tssmiArchGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.tssmiArchGuardar.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchGuardar.Text = "&Guardar"
        '
        'tssmiArchImprimir
        '
        Me.tssmiArchImprimir.Name = "tssmiArchImprimir"
        Me.tssmiArchImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.tssmiArchImprimir.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchImprimir.Text = "&Imprimir"
        '
        'tssmiArchCerrar
        '
        Me.tssmiArchCerrar.Name = "tssmiArchCerrar"
        Me.tssmiArchCerrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.tssmiArchCerrar.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchCerrar.Text = "&Cerrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'tssmiArchSesión
        '
        Me.tssmiArchSesión.Name = "tssmiArchSesión"
        Me.tssmiArchSesión.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchSesión.Text = "Iniciar &sesión"
        '
        'tssmiArchCambiarPass
        '
        Me.tssmiArchCambiarPass.Name = "tssmiArchCambiarPass"
        Me.tssmiArchCambiarPass.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchCambiarPass.Text = "Cambiar contrase&ña"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(188, 6)
        '
        'tssmiArchCatEmpr
        '
        Me.tssmiArchCatEmpr.Name = "tssmiArchCatEmpr"
        Me.tssmiArchCatEmpr.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchCatEmpr.Text = "Catálogo de &empresas"
        '
        'tssmiArchSelecEmpr
        '
        Me.tssmiArchSelecEmpr.Name = "tssmiArchSelecEmpr"
        Me.tssmiArchSelecEmpr.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchSelecEmpr.Text = "Se&leccionar empresa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'tssmiArchConfig
        '
        Me.tssmiArchConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssmiArchConfGenerales, Me.tssmiArchConfPlantillas, Me.tssmiArchConfUDI})
        Me.tssmiArchConfig.Name = "tssmiArchConfig"
        Me.tssmiArchConfig.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchConfig.Text = "Con&figuración"
        '
        'tssmiArchConfGenerales
        '
        Me.tssmiArchConfGenerales.Name = "tssmiArchConfGenerales"
        Me.tssmiArchConfGenerales.Size = New System.Drawing.Size(193, 22)
        Me.tssmiArchConfGenerales.Text = "Datos generales"
        '
        'tssmiArchConfPlantillas
        '
        Me.tssmiArchConfPlantillas.Name = "tssmiArchConfPlantillas"
        Me.tssmiArchConfPlantillas.Size = New System.Drawing.Size(193, 22)
        Me.tssmiArchConfPlantillas.Text = "Ubicación de plantillas"
        '
        'tssmiArchConfUDI
        '
        Me.tssmiArchConfUDI.Name = "tssmiArchConfUDI"
        Me.tssmiArchConfUDI.Size = New System.Drawing.Size(193, 22)
        Me.tssmiArchConfUDI.Text = "Valor de la UDI"
        '
        'tssmiArchSeguridad
        '
        Me.tssmiArchSeguridad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem67, Me.ToolStripMenuItem68, Me.ToolStripMenuItem69, Me.ToolStripMenuItem70})
        Me.tssmiArchSeguridad.Name = "tssmiArchSeguridad"
        Me.tssmiArchSeguridad.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchSeguridad.Text = "Se&guridad"
        '
        'ToolStripMenuItem67
        '
        Me.ToolStripMenuItem67.Name = "ToolStripMenuItem67"
        Me.ToolStripMenuItem67.Size = New System.Drawing.Size(243, 22)
        Me.ToolStripMenuItem67.Text = "Rastreo de modulos y funciones"
        '
        'ToolStripMenuItem68
        '
        Me.ToolStripMenuItem68.Name = "ToolStripMenuItem68"
        Me.ToolStripMenuItem68.Size = New System.Drawing.Size(243, 22)
        Me.ToolStripMenuItem68.Text = "Acceso a plazas"
        '
        'ToolStripMenuItem69
        '
        Me.ToolStripMenuItem69.Name = "ToolStripMenuItem69"
        Me.ToolStripMenuItem69.Size = New System.Drawing.Size(243, 22)
        Me.ToolStripMenuItem69.Text = "Acceso a módulos"
        '
        'ToolStripMenuItem70
        '
        Me.ToolStripMenuItem70.Name = "ToolStripMenuItem70"
        Me.ToolStripMenuItem70.Size = New System.Drawing.Size(243, 22)
        Me.ToolStripMenuItem70.Text = "Usuarios y acceso"
        '
        'tssmiArchSalir
        '
        Me.tssmiArchSalir.Name = "tssmiArchSalir"
        Me.tssmiArchSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.tssmiArchSalir.Size = New System.Drawing.Size(191, 22)
        Me.tssmiArchSalir.Text = "&Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(172, 6)
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbImprimir, Me.tsbNuevo, Me.tsbCancelar, Me.tsbBorrar, Me.tsbBuscar})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(984, 25)
        Me.MainToolStrip.TabIndex = 18
        Me.MainToolStrip.Text = "ToolStrip1"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "Imprimir"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.RightToLeftAutoMirrorImage = True
        Me.tsbCancelar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'tsbBorrar
        '
        Me.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBorrar.Image = CType(resources.GetObject("tsbBorrar.Image"), System.Drawing.Image)
        Me.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBorrar.Name = "tsbBorrar"
        Me.tsbBorrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBorrar.Text = "Borrar"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBuscar.Text = "Buscar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CopiarToolStripMenuItem1.Text = "&Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PegarToolStripMenuItem.Text = "&Pegar"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 692)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = Global.Diocesis.My.Resources.Resources.seminario
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diócesis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tsslServidor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslBaseDeDatos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslConexion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslEjercicio As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchCerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssmiArchSesión As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchCambiarPass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssmiArchCatEmpr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchSelecEmpr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssmiArchConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchConfGenerales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchConfPlantillas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchConfUDI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchSeguridad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem67 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem68 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem69 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem70 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiArchSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEdicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsslFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents tsslHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsmSeminario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRegistroDeAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrFechaHora As System.Windows.Forms.Timer
    Friend WithEvents tssmReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiRptListaAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiParticipaciónEnEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatálogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatParticipantes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiEdiDeshacer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiEdiCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiEdiCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiEdiPegar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiVenCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiVenMosaicoHoriz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiVenMosaicoVert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiVenOrganIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiVenAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmBiblioteca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmSeminario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmGenerales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatPaises As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatRamas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatTematicas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatEditoriales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatAutores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssmiCatLibros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParrocosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParroquiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
