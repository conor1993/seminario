using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CN = ClasesNegocio;
using Integralab.ORMSeguridad;
using R = ClasesSeminario.Reportes;

namespace ClasesSeminario
{
    public partial class frmRepListaAsistencia : Form, CN.iForm
    {
        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private DataSet dtsEventos = new DataSet();
        private DataSet dtsAños = new DataSet();
        private DataSet dtsEquipos = new DataSet();
        private DataSet dtsZonas = new DataSet();
        

        public frmRepListaAsistencia()
        {
            InitializeComponent();
        }

    #region iForm
        void CN.iForm.Imprimir()
        {
            if (cmbEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string cons;
                cons = "SELECT a.IdParticipante, rtrim(r.ApellidoPaterno)+'  '+rtrim(r.ApellidoMaterno)+'  '+rtrim(r.Nombre) as Nombre, " +
                        "r.Nombre as Nom,r.ApellidoPaterno,r.ApellidoMaterno, " +
                        "a.IdEvento, e.Nombreevento, " +
                        "dbo.CalculaEdad(r.FechaNacim) as Edad, a.GradoEscolar, " +
                        "a.CodParroqia,p.Nomparr,c.Nomciudad, " +
                        "a.IdEquipo,q.Nombreequipo,q.Encargado, " +
                        "a.Observaciones,a.Foto,a.Telefono,a.Celular, " +
                        "a.RedesSociales,a.eMail,z.Nomzonapastoral " +
                        "FROM SemAsistencia a " +
                        "Left Join CatEventos e on e.IdEvento=a.IdEvento " +
                        "Left Join CatEquiposTrabajo q on q.Idequipo=a.IdEquipo " +
                        "Left Join CatParroquias p on p.Idparroquia=a.CodParroqia " +
                        "Left Join CatZonaPastoral z on z.Idzonapastoral=p.Idzonapastoral " +
                        "Left Join CatCiudades c on c.Idciudad=p.Idciudad " +
                        "Left Join CatParticipantes r on r.IdParticipante=a.IdParticipante " +
                        "WHERE a.IdEvento='" + cmbEvento.SelectedValue.ToString() + "'";
                cons = cons + ((int)cmbEquipo.SelectedValue == 0 ? "" : " and a.IdEquipo=" + cmbEquipo.SelectedValue.ToString());
                cons = cons + ((byte)cmbZona.SelectedValue == 0 ? "" : " and p.Idzonapastoral=" + cmbZona.SelectedValue.ToString());
                cons = cons + " order by IdEvento,IdEquipo,ApellidoPaterno,ApellidoMaterno,Nom";

                SqlCommand cmd = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap = new SqlDataAdapter();
                DtAdap.SelectCommand = cmd;
                dtsGral.Clear();
                DtAdap.Fill(dtsGral);
                DtAdap = null;

                if (cmbTipo.SelectedIndex==0) // simplificado
                {
                    R.SemListaAsistencia Reporte = new R.SemListaAsistencia();
                    Reporte.SetDataSource(dtsGral.Tables[0]);
                    Reporte.SetParameterValue("Empresa", CN.Controlador.Sesion.MiEmpresa.Empnom);
                    Reporte.SetParameterValue("Usuario", CN.Controlador.Sesion.MiUsuario.Usrnomcom);
                    //Reporte.SetParameterValue("FechaFin", DtpFecha.Value);

                    CN.VisorReportes visor = new CN.VisorReportes();
                    visor.Text = "Listado de Asistencia";
                    visor.Reporte = Reporte;
                    visor.ShowDialog();

                }
                else        // detallado
                {
                    R.SemListaAsistenciaDet Reporte = new R.SemListaAsistenciaDet();
                    Reporte.SetDataSource(dtsGral.Tables[0]);
                    Reporte.SetParameterValue("Empresa", CN.Controlador.Sesion.MiEmpresa.Empnom);
                    Reporte.SetParameterValue("Usuario", CN.Controlador.Sesion.MiUsuario.Usrnomcom);
                    //Reporte.SetParameterValue("FechaFin", DtpFecha.Value);

                    CN.VisorReportes visor = new CN.VisorReportes();
                    visor.Text = "Listado de Asistencia";
                    visor.Reporte = Reporte;
                    visor.ShowDialog();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }

        }

        void CN.iForm.Nuevo()
        {
            cmbAño.SelectedIndex = -1;
            cmbEvento.SelectedIndex = -1;
            cmbEquipo.SelectedIndex = -1;
        }

        void CN.iForm.Borrar() { }
        void CN.iForm.Buscar() { }
        void CN.iForm.Cancelar() { }
        void CN.iForm.Guardar() { }
        Boolean[] CN.iForm.ToolBarStatus
        { 
            get; 
            set; 
        }

    #endregion

        private void frmRepListaAsistencia_Load(object sender, EventArgs e)
        {
            try
            {
                // inicializa el combo de años
                DtAdap = new SqlDataAdapter();
                DtAdap.SelectCommand = new SqlCommand("SELECT Distinct Yearevento FROM CatEventos", CN.DBU.Cnn);
                DtAdap.Fill(dtsAños);
                DtAdap.Dispose();
                cmbAño.ValueMember = "Yearevento";
                cmbAño.DisplayMember = "Yearevento";
                cmbAño.DataSource = dtsAños.Tables[0];
                cmbAño.SelectedIndex = -1;
                cmbTipo.SelectedIndex = 1;

                DtAdap = new SqlDataAdapter();
                DtAdap.SelectCommand = new SqlCommand("SELECT Idzonapastoral,Nomzonapastoral FROM CatZonaPastoral where Idzonapastoral<>0", CN.DBU.Cnn);
                DtAdap.Fill(dtsZonas);
                DtAdap.Dispose();
                dtsZonas.Tables[0].Rows.Add(0, "TODOS");
                cmbZona.ValueMember = "Idzonapastoral";
                cmbZona.DisplayMember = "Nomzonapastoral";
                cmbZona.DataSource = dtsZonas.Tables[0];
                cmbZona.SelectedValue = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // inicializa el combo de eventos
                DtAdap = new SqlDataAdapter();
                if (cmbAño.SelectedIndex != -1)
                    DtAdap.SelectCommand = new SqlCommand("SELECT Idevento, Nombreevento FROM CatEventos Where YearEvento=" + cmbAño.Text, CN.DBU.Cnn);
                else
                    DtAdap.SelectCommand = new SqlCommand("SELECT Idevento, Nombreevento FROM CatEventos", CN.DBU.Cnn);
                dtsEventos.Clear();
                DtAdap.Fill(dtsEventos);
                DtAdap = null;
                cmbEvento.ValueMember = "Idevento";
                cmbEvento.DisplayMember = "Nombreevento";
                cmbEvento.DataSource = dtsEventos.Tables[0];
                cmbEvento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedIndex == -1)
            {
                cmbEquipo.DataSource = null;
                cmbEquipo.Enabled = false;
            }
            else
            {
                try
                {
                    // inicializa el combo de equipos de trabajo
                    DtAdap = new SqlDataAdapter();
                    DtAdap.SelectCommand = new SqlCommand("SELECT Idequipo, Nombreequipo FROM CatEquiposTrabajo Where Idevento='" + cmbEvento.SelectedValue.ToString() + "'", CN.DBU.Cnn);
                    dtsEquipos.Clear();
                    DtAdap.Fill(dtsEquipos);
                    DtAdap.Dispose();
                    dtsEquipos.Tables[0].Rows.Add(0, "TODOS");
                    cmbEquipo.ValueMember = "Idequipo";
                    cmbEquipo.DisplayMember = "Nombreequipo";
                    cmbEquipo.DataSource = dtsEquipos.Tables[0];
                    cmbEquipo.SelectedValue = 0;
                    cmbEquipo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
