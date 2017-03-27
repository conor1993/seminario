using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CN = ClasesNegocio;
using r = ClasesSorteo.Reportes;
using ClasesNegocio;

namespace ClasesSorteo
{
    public partial class frmRptCumpleanos : Form, CN.iForm
    {



        String cons = "";
        String fechin = "";
        String fechci = "";

        DataView dvwParr;
        SqlDataAdapter DtAdap;
        DataSet dtsPar;

        DataSet dtsReporte = new DataSet();

        System.DateTime fechacorte;
        String fech;
        int diacorte;
        public frmRptCumpleanos()
        {
            InitializeComponent();
        }

        private void frmRptCumpleanos_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void llenargrid()
        {
            fechacorte = dtmdonaciones.Value;

            cons = "select nombre +' '+ApellidoPaterno+' '+ApellidoMaterno as nombre, Cumpleanos from SortCatBienechores where datepart(MM ,Cumpleanos)=  " + fechacorte.Month.ToString();

            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = new SqlCommand(cons, CN.DBU.Cnn);
            dtsPar = new DataSet();
            dtsPar.Tables.Clear();
            DtAdap.Fill(dtsPar);
            DtAdap = null;
            dgvdonaciones.AutoGenerateColumns = false;
            dvwParr = new DataView(dtsPar.Tables[0]);
            dgvdonaciones.DataSource = dvwParr;
        }

        public bool[] ToolBarStatus
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
               
            }
        }

        public void Guardar()
        {
            
        }

        public void Imprimir()
        {
            generarreporte();
        }



        public void Nuevo()
        {
           
        }

        public void Cancelar()
        {
           
        }

        public void Borrar()
        {
           
        }

        public void Buscar()
        {
            
        }

        private void dtmdonaciones_ValueChanged(object sender, EventArgs e)
        {
            llenargrid();
        }

        private void generarreporte()
        {

            fechacorte = dtmdonaciones.Value;



            SqlCommand cmd = new SqlCommand("exec ListaDeCumpleaños " + fechacorte.Month, CN.DBU.Cnn);

            cmd.CommandTimeout = 450;
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = cmd;
            dtsReporte.Clear();
            DtAdap.Fill(dtsReporte);

            if (dtsReporte.Tables[0].Rows.Count > 0)
            {
                r.SortListaCumpleanos reporte = new r.SortListaCumpleanos();
                reporte.SetDataSource(dtsReporte.Tables[0]);
                CN.VisorReportes visor = new CN.VisorReportes();
                visor.Text = "";
                visor.Reporte = reporte;
                visor.ShowDialog();
            }


        }
    }

}
