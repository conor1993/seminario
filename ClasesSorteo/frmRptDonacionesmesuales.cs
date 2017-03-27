using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CN = ClasesNegocio;
using System.Data.SqlClient;
using r = ClasesSorteo.Reportes;
using ClasesNegocio;

namespace ClasesSorteo
{
    public partial class frmRptDonacionesmesuales : Form, CN.iForm
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
        public frmRptDonacionesmesuales()
        {
            InitializeComponent();
        }

        private void frmRptDonacionesmesuales_Load(object sender, EventArgs e)
        {
            llenargrid();
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

            imprimirReporte();

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

        private void llenargrid()
        {

            fechacorte = dtmdonaciones.Value;


            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

            cons = "select  sum(pag.Cantidad) as Cantidad , tpp.Nombre as Pago ,pro.Nombre as Campaña "
		          + " from SortCatBienechores as bn join SortPagos as pag on bn.id = pag.IdBienechor "
		          + " join SortCatTipopago as tpp on tpp.Id = bn.IdTipopago "
		          + " join SortCatProgramas pro on pro.id = bn.IdPrograma "
                  + " where pag.Fecha  BETWEEN '" + fechin + "' AND '" + fechci + "' "
		          + " group by  tpp.Nombre , pro.Nombre";


          



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

        private void dtmdonaciones_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                llenargrid();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }


        private void imprimirReporte()
        {
            fechacorte = dtmdonaciones.Value;

            fechin = fechacorte.Year.ToString() + "-" + fechacorte.Month.ToString() + "-" + "15";
            fechci = fechacorte.Year.ToString() + "-" + fechacorte.AddMonths(1).Month.ToString() + "-" + "14";

            SqlCommand cmd = new SqlCommand("exec ListaDeDonacionesmes '" + fechin + "' , '" + fechci + "'", CN.DBU.Cnn);

            cmd.CommandTimeout = 450;
            DtAdap = new SqlDataAdapter();
            DtAdap.SelectCommand = cmd;
            dtsReporte.Clear();
            DtAdap.Fill(dtsReporte);

            if (dtsReporte.Tables[0].Rows.Count > 0)
            {
                r.SortListaDonacionesMensuales reporte = new r.SortListaDonacionesMensuales();
                reporte.SetDataSource(dtsReporte.Tables[0]);
                CN.VisorReportes visor = new CN.VisorReportes();
                visor.Text = "";
                visor.Reporte = reporte;
                visor.ShowDialog();
            }
        }
    }
}
