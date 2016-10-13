Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports IntegraLab.FormasSeguridad
Imports Integralab.ORMSeguridad
Imports ClasesNegocio

Module Inicio

    Private limpiar As Boolean = True
    Public Controlador As Controlador = Nothing
    Public SesionActual As ECS.SesionesEntity
    'Public frmSplash As frmSplashScreen
    'Public ConfiguracionGeneral As Integralab.ORM.EntityClasses.UsrConfiguracionGeneralEntity

    <STAThread()> _
    Sub main()
        Dim MdiPrincipal As frmMenuPrincipal, FrmLogin As LoginForm

        Try
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)

            Controlador = New Controlador()
        Catch ex As Exception
            'MsgBox("No se encontró configuración de seguridad. Capture los datos necesarios", MsgBoxStyle.Information, "Seguridad")
            'Dim segini As Integralab.Seguridad.Classes.Seguridad()
            'Dim frmSegLogin As New SeguridadLoginForm

            'frmSegLogin.Show()
            MessageBox.Show(ex.Message + vbNewLine + ex.Source + vbNewLine + vbNewLine + ex.StackTrace, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End Try
        Try
            MdiPrincipal = New frmMenuPrincipal()
            FrmLogin = New LoginForm(Controlador.Seguridad, DirectCast(MdiPrincipal, System.Windows.Forms.Form))

            FrmLogin.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            FrmLogin.LogoPictureBox.Size = New System.Drawing.Size(167, 193)
            'FrmLogin.LogoPictureBox.Image = My.Resources.LogoInicioSesion

            If FrmLogin.ShowDialog = DialogResult.OK Then
                'frmSplash.Show()
                Controlador.IniciarSesion(FrmLogin.Empresa.Empndx, FrmLogin.Usuario.Usrndx)
                SesionActual = Controlador.Sesion

                'Dim col As New CC.UsrConfiguracionGeneralCollection
                'col.GetMulti(Nothing, 1)
                'If col.Count > 0 Then
                '    arranque.ConfiguracionGeneral = col(0)
                'End If
                Controlador.ActualizarMenu(MdiPrincipal.MainMenuStrip)

                'Inicializar otros modulos
                'Controlador.Modulos.FacturacionDigital.InicializarModulo()

                Application.Run(MdiPrincipal)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbNewLine + ex.Source + vbNewLine + vbNewLine + ex.StackTrace, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "SIDEVI")
            Return
        End Try
    End Sub
End Module