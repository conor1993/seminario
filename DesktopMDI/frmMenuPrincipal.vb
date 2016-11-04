Option Explicit On
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports CCS = IntegraLab.ORMSeguridad.CollectionClasses
Imports HCS = IntegraLab.ORMSeguridad.HelperClasses
Imports IntegraLab.FormasSeguridad
Imports ClasesNegocio
Imports ClasesSeminario
Imports ClasesBiblioteca
Imports ClasesSorteo
Imports ClasesBiblioteca.Formas.Catalogos

Public Class frmMenuPrincipal

    Private Const WM_USER = &H400
    Private Const WM_CUT = &H300
    Private Const WM_COPY = &H301
    Private Const WM_PASTE = &H302
    Private Const WM_CLEAR = &H303
    Private Const WM_UNDO = &H304
    Private Const EM_CANUNDO = &HC6
    Private Const EM_UNDO = &HC7

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, _
                                                                            ByVal wParam As Long, ByVal lParam As VariantType) As Long
    'Dim loSesion As New Obra.Sesion
    Public SesionActual As ECS.SesionesEntity

#Region "Constructores"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region

#Region "Eventos"
    Private Sub MenuPrincipal_Load(sender As System.Object, e As System.EventArgs)
        'TlStrpGral.Left = 160
        'TlStrpGral.Top = 21
        'TlStrpStandar.Left = 0
        'TlStrpStandar.Top = 21
        'Status.Items.Item(1).Alignment = ToolStripItemAlignment.Right
        Me.tsslServidor.Text = "Srv:" + Controlador.Sesion.MiEmpresa.Empsrv
        Me.tsslBaseDeDatos.Text = "BD: " + Controlador.Sesion.MiEmpresa.Empcat
        Me.tsslUsuario.Text = "Usr: " + Controlador.Sesion.MiUsuario.Usrnom
        Me.tsslConexion.Text = "Cnx: " + System.Environment.UserName.ToString()
        Me.tsslVersion.Text = " Ver " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
#If Licencia = "Si" Then
        licContador = 0
        Randomize()
        InicializaConteo()
#End If
        tmrFechaHora.Enabled = True
        'frmSplash.Close()
    End Sub

    Private Sub tmrFechaHora_Tick(sender As System.Object, e As System.EventArgs)
        Static mostrado As Boolean = False
        Dim tiempo As DateTime = Now
        Me.tsslFecha.Text = Format(tiempo, "d")
        Me.tsslHora.Text = Format(tiempo, "t")
        tmrFechaHora.Interval = (60 - CInt(Val(Format(tiempo, "ss")))) * 1000
#If Licencia = "Si" Then
        If Now > #12/15/2012 4:00:00 PM# Then
            licContador += 1
            Dim forma As New frmLicencia
            If Not mostrado Then
                If (licContador) > licLimite Then
                    licContador = 0
                    mostrado = True
                    forma.ShowDialog()
                    InicializaConteo()
                    mostrado = False
                End If
            End If
        End If
#End If
    End Sub

#End Region

#Region "Licencia"
#If Licencia = "Si" Then
    Public licContador, licLimite As Integer

    Private Sub InicializaConteo()
        licContador = 0
        licLimite = Int(6 + (Rnd() * 14))
    End Sub
#End If
#End Region

    Private Sub Status_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        'Status.Items.Item(9).
    End Sub

#Region "MenuArchivo"
    Private Sub tssmiArchSalir_Click(sender As System.Object, e As System.EventArgs)
        Cerrar()
    End Sub
#End Region

#Region "MenuEdicion"
    Private Sub tssmiEdiCopiar_Click(sender As System.Object, e As System.EventArgs) Handles tssmiEdiCopiar.Click
        If (Not Me.ActiveMdiChild Is Nothing) Then
            Dim lsDatosCopiados As TextBox = TryCast(Me.ActiveMdiChild.ActiveControl, TextBox)

            If (Not lsDatosCopiados Is Nothing) Then
                Clipboard.SetDataObject(lsDatosCopiados.SelectedText)
            Else
                'MessageBox.Show("Objeto no soportado.")
            End If
        End If
    End Sub

    Private Sub tssmiEdiPegar_Click(sender As System.Object, e As System.EventArgs) Handles tssmiEdiPegar.Click
        ' si hay una ventana hija activa, encuentra el control activo
        If (Not Me.ActiveMdiChild Is Nothing) Then
            Try
                Dim lsDatosCopiados As TextBox = CType(Me.ActiveMdiChild.ActiveControl, TextBox)
                If (Not lsDatosCopiados Is Nothing) Then
                    ' Crea una nueva instancia de la interface DataObject.
                    Dim data As IDataObject = Clipboard.GetDataObject()
                    ' si el tipo de datos es texto, guarda en el texto del control el texto del portapapeles
                    If (data.GetDataPresent(DataFormats.Text)) Then
                        lsDatosCopiados.SelectedText = data.GetData(DataFormats.Text).ToString()
                    End If
                End If
            Catch
                'MessageBox.Show("No se pudo pegar la informacion.")
            End Try
        End If
    End Sub
#End Region

#Region "MenuVentana"

    Private Sub tssmiVenCascada_Click(sender As System.Object, e As System.EventArgs) Handles tssmiVenCascada.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub tssmiVenMosaicoHoriz_Click(sender As System.Object, e As System.EventArgs) Handles tssmiVenMosaicoHoriz.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub tssmiVenMosaicoVert_Click(sender As System.Object, e As System.EventArgs) Handles tssmiVenMosaicoVert.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub tssmiVenOrganIconos_Click(sender As System.Object, e As System.EventArgs) Handles tssmiVenOrganIconos.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons)
    End Sub

    Private Sub tssmiVenAcercaDe_Click(sender As System.Object, e As System.EventArgs) Handles tssmiVenAcercaDe.Click
        frmAcercaDe.ShowDialog(Me)
    End Sub

    'Private Sub MenuItemCascada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.LayoutMdi(MdiLayout.Cascade)
    'End Sub

    'Private Sub MenuItemMosaicoHoriz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileHorizontal)
    'End Sub

    'Private Sub MenuItemMosaicoVert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.LayoutMdi(MdiLayout.TileVertical)
    'End Sub

    'Private Sub MenuItemOrganizarIconos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub
#End Region

#Region "SubClases"
    Class Forma(Of tipoForma As {IDisposable, Windows.Forms.Form, New})
        Sub New(ByVal Padre As frmMenuPrincipal)
            Try
                Dim miForma As tipoForma = Nothing
                For Each frm As Windows.Forms.Form In Padre.MdiChildren
                    If frm.GetType() Is GetType(tipoForma) Then
                        miForma = DirectCast(frm, tipoForma)
                        Exit For
                    End If
                Next
                If IsNothing(miForma) Then
                    miForma = New tipoForma
                    miForma.MdiParent = Padre
                    'miForma.Icon = My.Resources.Icono
                    miForma.Icon = Padre.Icon
                    miForma.Show()
                Else
                    miForma.Focus()
                    miForma.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.InnerException.ToString)
            End Try
        End Sub
    End Class
#End Region

#Region "Procedimientos"
    Private Sub Cerrar()
        If SesionActual IsNot Nothing Then
            SesionActual.Sesact = False
            SesionActual.Save()
        End If

        Me.Finalize()
        Me.Dispose()
        End
    End Sub
#End Region

#Region "Barra de botones"
    Public Sub BarraDeBotones(Estados As Boolean())
        Dim i As Integer, elem As Integer = UBound(Estados, 1)
        If elem > 6 Then elem = 6

        For i = 0 To elem - 1
            MainToolStrip.Items(i).Enabled = Estados(i)
        Next
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Guardar()
    End Sub

    Private Sub tsbImprimir_Click(sender As System.Object, e As System.EventArgs) Handles tsbImprimir.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Imprimir()
    End Sub

    Private Sub tsbNuevo_Click(sender As System.Object, e As System.EventArgs) Handles tsbNuevo.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Nuevo()
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Cancelar()
    End Sub

    Private Sub tsbBorrar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBorrar.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Borrar()
    End Sub

    Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click
        If Me.ActiveMdiChild Is Nothing Then
            Exit Sub
        End If
        Dim frm As iForm
        frm = CType(Me.ActiveMdiChild, iForm)
        frm.Buscar()
    End Sub
#End Region

#Region "FormasCatalogos"
    Private Sub EstatusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EstatusToolStripMenuItem.Click
        Dim forma As New Forma(Of frmCatEstatus)(Me)
    End Sub
    Private Sub FormatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormatosToolStripMenuItem.Click
        Dim forma As New Forma(Of frmCatFormato)(Me)
    End Sub
    Private Sub LectoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LectoresToolStripMenuItem.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatLectores)(Me)
    End Sub
    Private Sub tssmiCatPaises_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatPaises.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatPaises)(Me)
    End Sub

    Private Sub tsmiCatEventos_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatEventos.Click
        Dim forma As New Forma(Of ClasesSeminario.frmCatEventos)(Me)
    End Sub

    Private Sub tsmiCatParticipantes_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatParticipantes.Click
        Dim forma As New Forma(Of ClasesSeminario.frmCatParticipantes)(Me)
    End Sub

    Private Sub tssmiCatSecciones_Click(sender As System.Object, e As System.EventArgs)
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatSecciones)(Me)
    End Sub

    Private Sub tssmiCatRamas_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatRamas.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatRamas)(Me)
    End Sub

    Private Sub tssmiCatTematicas_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatTematicas.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatTematicas)(Me)
    End Sub

    Private Sub tssmiCatEditoriales_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatEditoriales.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatEditoriales)(Me)
    End Sub

    Private Sub tssmiCatAutores_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatAutores.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmCatAutores)(Me)
    End Sub

    Private Sub tssmiCatLibros_Click(sender As System.Object, e As System.EventArgs) Handles tssmiCatLibros.Click
        Dim forma As New Forma(Of ClasesBiblioteca.frmInvLibros)(Me)
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CToolStripMenuItem.Click
        Dim forma As New Forma(Of ClasesSorteo.frmEquipos)(Me)

    End Sub

    Private Sub BienechoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BienechoresToolStripMenuItem.Click
        Dim forma As New Forma(Of ClasesSorteo.frmBienechores)(Me)
    End Sub
#End Region




#Region "FormasSeminario"
    Private Sub ParroquiasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParroquiasToolStripMenuItem.Click
        Dim forma As New Forma(Of ClasesSeminario.frmCatparroquias)(Me)
    End Sub
    Private Sub ParrocosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParrocosToolStripMenuItem.Click
        Dim forma As New Forma(Of ClasesSeminario.frmCatParrocos)(Me)
    End Sub
    Private Sub tsmiRegistroDeAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRegistroDeAsistencia.Click
        Dim forma As New Forma(Of ClasesSeminario.frmCapturaAsistencia)(Me)
    End Sub

    Private Sub tssmiRptListaAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiRptListaAsistencia.Click
        Dim forma As New Forma(Of ClasesSeminario.frmRepListaAsistencia)(Me)
    End Sub

    Private Sub ParticipaciónEnEventosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tssmiParticipaciónEnEventos.Click
        Dim forma As New Forma(Of ClasesSeminario.frmRepParticipEventos)(Me)
    End Sub
#End Region


End Class
