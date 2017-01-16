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
    public partial class frmRepParticipEventos : Form, CN.iForm
    {
        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private DataSet dtsEventos = new DataSet();
        private DataSet dtsParticipantes = new DataSet();
        private DataSet dtsEquipos = new DataSet();

        public frmRepParticipEventos()
        {
            InitializeComponent();
        }

    #region iForm
        void CN.iForm.Imprimir()
        {
            if (cmbNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string cons;
                cons = "SELECT a.IdParticipante, rtrim(r.ApellidoPaterno)+' '+rtrim(r.ApellidoMaterno)+' '+rtrim(r.Nombre) as Nombre, " +
                        "(CASE WHEN r.Aceptado=1 THEN 'SI' WHEN  r.Aceptado=2 THEN 'NO'  WHEN  r.Aceptado=3 THEN 'SF' WHEN  r.Aceptado=4 THEN 'ND' END) as Estado, " +
                        "(CASE WHEN r.FechaNacim='1900-01-01T00:00:00' THEN 0 ELSE dbo.CalculaEdad(r.FechaNacim) END) as Edad, " +
                        "a.IdEvento, e.Nombreevento, e.FecIniEvento, e.FecFinEvento, a.Observaciones, " +
                        "ua.Foto, ua.Domicilio, ua.Telefono, ua.Celular, ua.RedesSociales, ua.eMail " +
                        "FROM CatParticipantes r " +
                        "Left Join CatEventos ue On ue.Idevento=(Select Top 1 sei.IdEvento From SemAsistencia sei " +
						"Left Join CatEventos cei On cei.Idevento=sei.IdEvento "+
						"Where sei.IdParticipante=r.IdParticipante " +
						"Order By cei.Fecinievento desc) "+
                        "Left Join SemAsistencia ua on ua.IdParticipante=r.IdParticipante and ua.IdEvento=ue.Idevento "+
                        "Inner Join SemAsistencia a on r.IdParticipante=a.IdParticipante " +
                        "Inner Join CatEventos e on e.IdEvento=a.IdEvento " +
                        "WHERE e.Fecinievento Between '" + dtpFecIni.Value.ToString("yyyy-MM-ddT00:00:00") + "'" + " and '" + dtpFecFin.Value.ToString("yyyy-MM-ddT11:59:59") + "'" +
                        ((int)cmbNombre.SelectedValue == 0 ? "" : " and a.IdParticipante=" + cmbNombre.SelectedValue.ToString()) +
                        " order by IdParticipante,FecIniEvento";

                SqlCommand cmd = new SqlCommand(cons, CN.DBU.Cnn);
                DtAdap = new SqlDataAdapter();
                DtAdap.SelectCommand = cmd;
                dtsGral.Clear();
                DtAdap.Fill(dtsGral);
                DtAdap = null;

                CN.VisorReportes visor = new CN.VisorReportes();
                if (cmbTipo.SelectedIndex == 1) // simplificado
                {
                    R.SemParticipEventos Reporte = new R.SemParticipEventos();
                    Reporte.SetDataSource(dtsGral.Tables[0]);
                    Reporte.SetParameterValue("Empresa", CN.Controlador.Sesion.MiEmpresa.Empnom);
                    Reporte.SetParameterValue("Usuario", CN.Controlador.Sesion.MiUsuario.Usrnomcom);
                    visor.Reporte = Reporte;
                    visor.Text = "Participación en Eventos";
                    visor.ShowDialog();
                    Reporte.Dispose();
                }
                else    // Detallado
                {
                    R.SemParticipEventosDet Reporte = new R.SemParticipEventosDet();
                    Reporte.SetDataSource(dtsGral.Tables[0]);
                    Reporte.SetParameterValue("Empresa", CN.Controlador.Sesion.MiEmpresa.Empnom);
                    Reporte.SetParameterValue("Usuario", CN.Controlador.Sesion.MiUsuario.Usrnomcom);
                    visor.Reporte = Reporte;
                    visor.Text = "Participación en Eventos";
                    visor.ShowDialog();
                    Reporte.Dispose();
                }
                visor.Dispose();
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
            cmbNombre.SelectedIndex = -1;
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
                DtAdap.SelectCommand = new SqlCommand("SELECT IdParticipante, RTrim(ApellidoPaterno)+' '+RTrim(ApellidoMaterno)+' '+RTrim(Nombre) as Nombre FROM CatParticipantes Order By Nombre", CN.DBU.Cnn);
                DtAdap.Fill(dtsParticipantes);
                DtAdap = null;
                dtsParticipantes.Tables[0].Rows.Add(0, "TODOS");
                cmbNombre.ValueMember = "IdParticipante";
                cmbNombre.DisplayMember = "Nombre";
                cmbNombre.DataSource = dtsParticipantes.Tables[0];
                cmbNombre.SelectedValue = 0;
                dtpFecFin.Value = DateTime.Now;
                cmbTipo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // inicializa el combo de equipos de trabajo
        //        //DtAdap = new SqlDataAdapter();
        //        //DtAdap.SelectCommand = new SqlCommand("SELECT Idequipo, Nombreequipo FROM CatEquiposTrabajo Where Idevento='" + cmbNombre.SelectedValue.ToString() + "'", CN.DBU.Cnn);
        //        //dtsEquipos.Clear();
        //        //DtAdap.Fill(dtsEquipos);
        //        //DtAdap = null;
        //        //cmbEquipo.ValueMember = "Idequipo";
        //        //cmbEquipo.DisplayMember = "Nombreequipo";
        //        //cmbEquipo.DataSource = dtsEquipos.Tables[0];
        //        //cmbEquipo.SelectedIndex = -1;
        //        //cmbEquipo.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

    }
}
